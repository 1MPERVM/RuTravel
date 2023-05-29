using Microsoft.EntityFrameworkCore;
using RuTravel.Application.Interfaces;
using RuTravel.Domain;
using System.Reflection.Metadata;

namespace RuTravel.Persistence
{
    public class SightsRepo : ISightsRepo
    {
        private readonly RuTravelDBContext _dbContext;
        public SightsRepo(RuTravelDBContext dBContext) => _dbContext = dBContext;
        public async void CreateSightAsync(Sights sight)
        {
            if (sight == null)
            {
                throw new ArgumentNullException(nameof(sight));
            }
            await _dbContext.AddAsync(sight);
        }

        public async Task<IEnumerable<Sights>> GetAllSightsAsync() => await _dbContext.Sights.ToListAsync();

        public async Task<Sights> GetSightByIdAsync(int id) => await _dbContext.Sights.FirstOrDefaultAsync(sight => sight.Id == id);

        public async void SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
