using Microsoft.EntityFrameworkCore;
using RuTravel.Application.Interfaces;
using RuTravel.Domain;

namespace RuTravel.Persistence
{
    public class FlatsRepo : IFlatsRepo
    {
        private readonly RuTravelDBContext _dbContext;
        public FlatsRepo(RuTravelDBContext dBContext) => _dbContext = dBContext;
        public async Task<IEnumerable<Flats>> GetAllFlatsAsync() => await _dbContext.Flats.ToListAsync();

        public async Task<Flats> GetFlatByIdAsync(int id) => await _dbContext.Flats.FirstOrDefaultAsync(flat => flat.Id == id);
    }
}
