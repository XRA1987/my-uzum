namespace MyUzum.Infrastructure.Abstractions
{
    public interface IAuthServise
    {
        Task<string> LoginAsync(string username, string password);
    }
}
