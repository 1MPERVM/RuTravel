using RuTravel.Domain;

namespace RuTravel.Application.Interfaces
{
    public interface IFlatsRepo
    {
        Task<IEnumerable<Flats>> GetAllFlatsAsync();
        Task<Flats> GetFlatByIdAsync(int id);
    }
}
