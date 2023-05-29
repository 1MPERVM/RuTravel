using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RuTravel.Application.Interfaces;
using RuTravel.Domain;
using RuTravel.WebApi.DTO;

namespace RuTravel.WebApi.Controllers
{
    [Route("api/cafe/[controller]")]
    [ApiController]
    public class CafesController : ControllerBase
    {
        private readonly ICafesRepo _cafesRepo;

        private readonly IMapper _mapper;

        public CafesController(ICafesRepo cafesRepo, IMapper mapper) => (_cafesRepo, _mapper) = (cafesRepo, mapper);
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CafeReadDto>>> GetAllCafes()
        {
            var cafes = await _cafesRepo.GetAllCafesAsync();
            return Ok(_mapper.Map<IEnumerable<CafeReadDto>>(cafes));
        }

        [HttpGet("{id}", Name = "GetCafeById")]
        public async Task<ActionResult<CafeReadDto>> GetCafeById(int id)
        {
            var cafe = await _cafesRepo.GetCafeByIdAsync(id);
            if (cafe != null)
            {
                return Ok(_mapper.Map<CafeReadDto>(cafe));
            }

            return NotFound();
        }
    }
}
