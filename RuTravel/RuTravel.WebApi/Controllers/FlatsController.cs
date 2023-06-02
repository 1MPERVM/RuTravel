using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RuTravel.Application.Interfaces;
using RuTravel.Domain;
using RuTravel.Persistence;
using RuTravel.WebApi.DTO;

namespace RuTravel.WebApi.Controllers
{
    [Route("api/flat/[controller]")]
    [ApiController]
    public class FlatsController : ControllerBase
    {
        private readonly IFlatsRepo _flatsRepo;
        private readonly IMapper _mapper;

        public FlatsController(IFlatsRepo flatsRepo, IMapper mapper) => (_flatsRepo, _mapper) = (flatsRepo, mapper);
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FlatReadDto>>> GetAllFlats()
        {
            var flats = await _flatsRepo.GetAllFlatsAsync();
            return Ok(_mapper.Map<IEnumerable<FlatReadDto>>(flats));
        }

        [HttpGet("{id}", Name = "GetFlatById")]
        public async Task<ActionResult<Flats>> GetFlatById(int id)
        {
            var flat = await _flatsRepo.GetFlatByIdAsync(id);
            if (flat != null)
            {
                return Ok(_mapper.Map<FlatReadDto>(flat));
            }

            return NotFound();
        }
    }
}
