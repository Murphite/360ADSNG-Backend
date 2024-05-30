using _360AdsNG.Domain.Entities;

namespace _360AdsNG.Domain.Interfaces;

public interface IJwtService
{
    public string GenerateToken(User user, IList<string> roles);
}
