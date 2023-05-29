using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RuTravel.Application.Interfaces;
using RuTravel.Domain;
using RuTravel.Persistence;
using RuTravel.WebApi.DTO;

namespace RuTravel.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TownsController : ControllerBase
    {
        private readonly ITownsRepo _townsRepo;
        private readonly IMapper _mapper;

        public TownsController(ITownsRepo townsRepo, IMapper mapper) => (_townsRepo, _mapper) = (townsRepo, mapper);

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TownReadDto>>> GetAllTowns()
        {
            var towns = await _townsRepo.GetAllTownsAsync();
            return Ok(_mapper.Map<TownReadDto>(towns));
        }

        [HttpGet("{id}", Name = "GetTownById")]
        public async Task<ActionResult<TownReadDto>> GetTowntById(int id)
        {
            var town = await _townsRepo.GetTownByIdAsync(id); 
            if (town != null)
            {
                return Ok(_mapper.Map<TownReadDto>(town));
            }

            return NotFound();
        }
    }
}
