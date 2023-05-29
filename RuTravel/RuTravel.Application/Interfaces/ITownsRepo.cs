using RuTravel.Domain;

namespace RuTravel.Application.Interfaces
{
    public interface ITownsRepo
    {
        Task<IEnumerable<Towns>> GetAllTownsAsync();
        Task<Towns> GetTownByIdAsync(int id);
    }
}
