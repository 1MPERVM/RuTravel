using Microsoft.EntityFrameworkCore;
using RuTravel.Application.Interfaces;
using RuTravel.Domain;

namespace RuTravel.Persistence
{
    public class CafesRepo : ICafesRepo
    {
        private readonly RuTravelDBContext _dbContext;
        public CafesRepo(RuTravelDBContext dBContext) => _dbContext = dBContext;

        public async Task<IEnumerable<Cafes>> GetAllCafesAsync() => await _dbContext.Cafes.ToListAsync();

        public async Task<Cafes> GetCafeByIdAsync(int id) => await _dbContext.Cafes.FirstOrDefaultAsync(cafe => cafe.Id == id);
    }
}
