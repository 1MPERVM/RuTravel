using Microsoft.EntityFrameworkCore;
using RuTravel.Application.Interfaces;
using RuTravel.Domain;

namespace RuTravel.Persistence
{
    public class PhotosRepo : IPhotosRepo
    {
        private readonly RuTravelDBContext _dbContext;
        public PhotosRepo(RuTravelDBContext dBContext) => _dbContext = dBContext;
        public void CreatePhotoAsync(Photos photo)
        {
            if (photo == null)
            {
                throw new ArgumentNullException(nameof(photo));
            }
            _dbContext.Photos.AddAsync(photo);

        }

        public void DeletePhotoById(int id)
        {
            var currentPhoto = _dbContext.Photos.FirstOrDefault(p => p.Id == id);
             _dbContext.Photos.Remove(currentPhoto);
        }

        public async Task<IEnumerable<Photos>> GetAllPhotos() => await _dbContext.Photos.ToListAsync();

        public async Task<Photos> GetPhotoByIdAsync(int id) => await _dbContext.Photos.FirstOrDefaultAsync(photo => photo.Id == id);

        public async void SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
