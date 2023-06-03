using Kiosko.Domain.Entities;

namespace Kiosko.Interfaces
{
    public interface IJwtUtils
    {
        public string GenerateJwtToken(Users user);
        public int? ValidateJwtToken(string? token);
    }
}
