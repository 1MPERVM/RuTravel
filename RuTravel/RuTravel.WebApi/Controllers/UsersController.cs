using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RuTravel.Application.Interfaces;
using RuTravel.Domain;
using RuTravel.Persistence;
using RuTravel.WebApi.DTO;

namespace RuTravel.WebApi.Controllers
{
    [Route("api/user/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsersRepo _usersRepo;
        private readonly IMapper _mapper;


        public UsersController(IUsersRepo usersRepo, IMapper mapper) => (_usersRepo, _mapper) = (usersRepo, mapper);

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserReadDto>>> GetAllUsers()
        {
            var users = await _usersRepo.GetAllUsersAsync();
            return Ok(_mapper.Map<UserReadDto>(users));
        }

        [HttpGet("{id}", Name = "GetUserById")]
        public async Task<ActionResult<UserReadDto>> GetUserById(int id)
        {
            var user =  _usersRepo.GetUserByIdAsync(id);
            if (user != null)
            {
                return Ok(_mapper.Map<UserReadDto>(user));
            }

            return NotFound();
        }

        [HttpPost]
        public async Task<ActionResult> CreateUser(UserCreateDto user)
        {
            var userModel = _mapper.Map<Users>(user);
            _usersRepo.CreateUserAsync(userModel);
            _usersRepo.SaveChangesAsync();

            var userReadDto = _mapper.Map<UserReadDto>(userModel);
            return Ok(new {Id = userReadDto.Id});
        }

        [HttpPut]
        public ActionResult UpdateUser(int id, UserUpdateDto userToUpdate)
        {
            var userFromRepository = _usersRepo.GetUserByIdAsync(id);

            if (userFromRepository == null)
            {
                return NotFound();
            }

            _mapper.Map(userToUpdate, userFromRepository);
            _usersRepo.UpdateUserAsync(userFromRepository);
            _usersRepo.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteUserById(int id)
        {
            var currentUser = _usersRepo.GetUserByIdAsync(id);
            if (currentUser == null)
            {
                return NotFound();
            }

            _usersRepo.DeleteUserById(id);
            _usersRepo.SaveChangesAsync();

            return NoContent();
        }
    }
}
