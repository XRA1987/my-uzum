using Uzum.Domain.Entities;

namespace MyUzum.Infrastructure.Abstractions
{
    public interface ITokenServise
    {
        string GenereteAccesToken(User user);
    }
}
