using Entities;

namespace Services
{
    public interface IusersServices
    {
        Task<User> loginAsync(User user);
        int passwordRate(string password);
        Task<User> registerAsync(User user);
    }
}