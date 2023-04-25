using Zxcvbn;
using Repository;
using Entities;
namespace Services
{
    public class usersServices : IusersServices
    {
        IusersRepository _repository;

       public  usersServices(IusersRepository repository)
        {
            _repository = repository;
        }


        public async Task<User> loginAsync(User user)
        {
            return await _repository.loginAsync(user);
        }

        public async Task<User> registerAsync(User user)
        {
            return await _repository.registerAsync(user);
        }
        public int passwordRate(string password)
        {
            var result = Zxcvbn.Core.EvaluatePassword(password);
            return result.Score;
        }

    }
}
