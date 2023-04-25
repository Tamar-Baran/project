using Entities;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
//using System.Text.Json


namespace Repository
{
    public class usersRepository : IusersRepository
    {
        //User user = new User();
        CouchesShop213664998Context _DbContext;

        public usersRepository(CouchesShop213664998Context dbContext)
        {
            _DbContext = dbContext;
        }


        public async Task<User> loginAsync(User userToSearch)
        {
           List<User> users = await _DbContext.Users.Where(user => userToSearch.email == user.Email && user.Password == userToSearch.password).ToListAsync();
            if (users != null)
                return users[0];
            return null;
        }
        public async Task<Boolean> existEmailAsync(String Email)
        {
            var users = await _DbContext.Users.Where(user => Email == user.Email).ToListAsync();
            if (users.Count > 0)
                return true;
            return false;
        }

        public async Task updateUserAsync(User userToUpdate, int id)
        {
            //_DbContext.Users.Update(userToUpdate);
            //await _DbContext.SaveChangesAsync();
            ////return userToUpdate;
        }
        public async Task<User> registerAsync(User newUser)
        {
            await _DbContext.Users.AddAsync(newUser);
            await _DbContext.SaveChangesAsync();
            return newUser;
        }

        public async Task<User> getUserAsync(int id)
        {
            return await _DbContext.Users.FindAsync(id);
            
        }
    }
}
