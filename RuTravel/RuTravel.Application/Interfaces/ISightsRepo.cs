

using RuTravel.Domain;

namespace RuTravel.Application.Interfaces
{
    public interface ISightsRepo
    {
        void SaveChangesAsync();
        Task<IEnumerable<Sights>> GetAllSightsAsync();
        Task<Sights> GetSightByIdAsync(int id);
        void CreateSightAsync(Sights sight);
    }
}
