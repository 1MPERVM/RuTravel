using RuTravel.Domain;

namespace RuTravel.Application.Interfaces
{
    public interface IUsersRepo
    {
        void SaveChangesAsync();
        Task<IEnumerable<Users>> GetAllUsersAsync();
        Users GetUserByIdAsync(int id);
        void CreateUserAsync(Users user);
        void UpdateUserAsync(Users user);
        void DeleteUserById(int id);
    }
}
