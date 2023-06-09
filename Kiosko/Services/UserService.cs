﻿using Kiosko.Domain.Entities;
using Kiosko.Interfaces;

namespace Kiosko.Services
{
    public class UserService : IUserService
    {
        // users hardcoded for simplicity, store in a db with hashed passwords in production applications
        private List<Users> _users = new List<Users>
    {
        new Users { Id = 1, FirstName = "Test", LastName = "User", Login = "test", Password = "test" }
    };

        private readonly IJwtUtils _jwtUtils;

        public UserService(IJwtUtils jwtUtils)
        {
            _jwtUtils = jwtUtils;
        }

        public AuthenticateResponse? Authenticate(AuthenticateRequest model)
        {
            var user = _users.SingleOrDefault(x => x.Login == model.Username && x.Password == model.Password);

            // return null if user not found
            if (user == null) return null;

            // authentication successful so generate jwt token
            var token = _jwtUtils.GenerateJwtToken(user);

            return new AuthenticateResponse(user, token);
        }

        public IEnumerable<Users> GetAll()
        {
            return _users;
        }

        public Users? GetById(int id)
        {
            return _users.FirstOrDefault(x => x.Id == id);
        }
    }
}
