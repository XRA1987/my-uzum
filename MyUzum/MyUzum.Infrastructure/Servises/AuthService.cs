using Microsoft.EntityFrameworkCore;
using MyUzum.Infrastructure.Abstractions;
using MyUzum.Infrastructure.Persistence;
using MyUzum.Infrastructure.Utils;

namespace MyUzum.Infrastructure.Servises
{
    public class AuthService : IAuthServise
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly ITokenServise _tokenServise;

        public AuthService(ApplicationDbContext dbContext, ITokenServise tokenServise)
        {
            _dbContext = dbContext;
            _tokenServise = tokenServise;
        }

        public async Task<string> LoginAsync(string username, string password)
        {
            var user = await _dbContext.Users.FirstOrDefaultAsync(x => x.UserName == username);

            if (user == null)
            {
                throw new Exception("Not Found");
            }
            if (user.PasswordHash != HashGenerate.Generate(password))
            {
                throw new Exception("Pasword is wrong");
            }
            return _tokenServise.GenereteAccesToken(user);
        }
    }
}
