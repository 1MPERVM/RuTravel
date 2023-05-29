using Microsoft.EntityFrameworkCore;
using RuTravel.Application.Interfaces;
using RuTravel.Domain;

namespace RuTravel.Persistence
{
    public class UsersRepo : IUsersRepo
    {
        private readonly RuTravelDBContext _dbContext;
        public UsersRepo(RuTravelDBContext dBContext) => _dbContext = dBContext;
        public async void CreateUserAsync(Users user)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));

            }
            await _dbContext.Users.AddAsync(user);
        }

        public void DeleteUserById(int id)
        {
            var currentUser = _dbContext.Users.FirstOrDefault(p => p.Id == id);
            _dbContext.Users.Remove(currentUser);
        }

        public async Task<IEnumerable<Users>> GetAllUsersAsync() => await _dbContext.Users.ToListAsync();

        public  Users GetUserByIdAsync(int id) =>  _dbContext.Users.FirstOrDefault(p => p.Id == id);

        public async void SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }

        public void UpdateUserAsync(Users user)
        {
            _dbContext.Users.Update(user);
        }

    }
    
}
