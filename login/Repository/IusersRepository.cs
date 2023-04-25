using Entities;

namespace Repository
{
    public interface IusersRepository
    {
        Task<User> loginAsync(User newUser);
        Task<User> registerAsync(User newUser);
    }
}