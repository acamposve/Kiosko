﻿using Kiosko.Domain.Entities;

namespace Kiosko.Interfaces
{
    public interface IUserService
    {
        AuthenticateResponse? Authenticate(AuthenticateRequest model);
        IEnumerable<Users> GetAll();
        Users? GetById(int id);
    }
}
