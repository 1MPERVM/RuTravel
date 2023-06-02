using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RuTravel.Application.Interfaces;
using RuTravel.Domain;
using RuTravel.Persistence;
using RuTravel.WebApi.DTO;

namespace RuTravel.WebApi.Controllers
{
    [Route("api/photo/[controller]")]
    [ApiController]
    public class PhotosController : ControllerBase
    {
        private readonly IPhotosRepo _photosRepo;
        private readonly IMapper _mapper;

        public PhotosController(IPhotosRepo photosRepo, IMapper mapper) => (_photosRepo, _mapper) = (photosRepo, mapper);
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PhotoReadDto>>> GetAllPhotos()
        {
            var photos = await _photosRepo.GetAllPhotos();
            return Ok(_mapper.Map<IEnumerable<PhotoReadDto>>(photos));
        }

        [HttpGet("{id}", Name = "GetPhotoById")]
        public async Task<ActionResult<PhotoReadDto>> GetPhotoById(int id)
        {
            var photo = await _photosRepo.GetPhotoByIdAsync(id);
            if (photo != null)
            {
                return Ok(_mapper.Map<PhotoReadDto>(photo));
            }

            return NotFound();
        }

        [HttpPost]
        public async Task<ActionResult> CreatePhoto(PhotoCreateDto photo)
        {
            var photoModel = _mapper.Map<Photos>(photo);
            _photosRepo.CreatePhotoAsync(photoModel);
            _photosRepo.SaveChangesAsync();

            var photoReadDto = _mapper.Map<PhotoReadDto>(photoModel);
            return Ok(new {Id = photoReadDto.Id});
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeletePhotoById(int id)
        {
            var currentPhoto = await _photosRepo.GetPhotoByIdAsync(id);
            if (currentPhoto == null)
            {
                return NotFound();
            }

            _photosRepo.DeletePhotoById(id);
            _photosRepo.SaveChangesAsync();

            return NoContent();
        }
    }
}
