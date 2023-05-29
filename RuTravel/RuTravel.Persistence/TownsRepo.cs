using Microsoft.EntityFrameworkCore;
using RuTravel.Application.Interfaces;
using RuTravel.Domain;

namespace RuTravel.Persistence
{
    public class TownsRepo : ITownsRepo
    {
        private readonly RuTravelDBContext _dbContext;
        public TownsRepo(RuTravelDBContext dBContext) => _dbContext = dBContext;
        public async Task<IEnumerable<Towns>> GetAllTownsAsync() => await _dbContext.Towns.ToListAsync();

        public async Task<Towns> GetTownByIdAsync(int id) => await _dbContext.Towns.FirstOrDefaultAsync(town => town.Id == id);
    }
}
