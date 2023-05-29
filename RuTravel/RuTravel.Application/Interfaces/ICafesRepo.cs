using RuTravel.Domain;

namespace RuTravel.Application.Interfaces
{
    public interface ICafesRepo
    {
        Task<IEnumerable<Cafes>> GetAllCafesAsync();
        Task<Cafes> GetCafeByIdAsync(int id);

    }
}
