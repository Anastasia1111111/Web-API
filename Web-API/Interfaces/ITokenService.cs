using Web_API.Entities;

namespace Web_API.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}
