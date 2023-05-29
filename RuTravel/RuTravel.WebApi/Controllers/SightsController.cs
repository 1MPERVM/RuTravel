using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RuTravel.Application.Interfaces;
using RuTravel.Domain;
using RuTravel.Persistence;
using RuTravel.WebApi.DTO;

namespace RuTravel.WebApi.Controllers
{
    [Route("api/sight/[controller]")]
    [ApiController]
    public class SightsController : ControllerBase
    {
        private readonly ISightsRepo _sightsRepo;
        private readonly IMapper _mapper;

        public SightsController(ISightsRepo sightsRepo, IMapper mapper) => (_sightsRepo, _mapper) = (sightsRepo, mapper);
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SightReadDto>>> GetAllSights()
        {
            var sights = await _sightsRepo.GetAllSightsAsync();
            return Ok(_mapper.Map<SightReadDto>(sights));
        }

        [HttpGet("{id}", Name = "GetSightById")]
        public async Task<ActionResult<SightReadDto>> GetSightById(int id)
        {
            var sight = await _sightsRepo.GetSightByIdAsync(id);
            if (sight != null)
            {
                return Ok(_mapper.Map<SightReadDto>(sight));
            }

            return NotFound();
        }

        [HttpPost]
        public async Task<ActionResult> CreateSight(SightCreateDto sight)
        {
            var sightModel = _mapper.Map<Sights>(sight);
            _sightsRepo.CreateSightAsync(sightModel);
            _sightsRepo.SaveChangesAsync();


            var sightReadDto = _mapper.Map<SightReadDto>(sightModel);
            return Ok(new {Id = sightReadDto.Id});
        }
    }
}
