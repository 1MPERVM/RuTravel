using RuTravel.Domain;

namespace RuTravel.Application.Interfaces
{
    public interface IPhotosRepo
    {
        void SaveChangesAsync();
        Task<IEnumerable<Photos>> GetAllPhotos();
        Task<Photos> GetPhotoByIdAsync(int id);
        void CreatePhotoAsync(Photos photo);
        void DeletePhotoById(int id);

    }
}
