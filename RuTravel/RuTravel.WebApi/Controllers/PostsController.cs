using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RuTravel.Application.Interfaces;
using RuTravel.Domain;
using RuTravel.Persistence;
using RuTravel.WebApi.DTO;

namespace RuTravel.WebApi.Controllers
{
    [Route("api/post/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly IPostsRepo _postRepo;
        private readonly IMapper _mapper;

        public PostsController(IPostsRepo postRepo, IMapper mapper) => (_postRepo, _mapper) = (postRepo, mapper);

        [HttpGet("{id}", Name = "GetPostByUserId")]
        public async Task<ActionResult<PostReadDto>> GetPostByUserId(int id)
        {
            var post = await _postRepo.GetPostsByUserIdAsync(id);
            if (post != null)
            {
                return Ok(_mapper.Map<PostReadDto>(post));
            }

            return NotFound();
        }

        [HttpPost]
        public async Task<ActionResult> CreatePost(PostCreateDto post)
        {
            var postModel = _mapper.Map<Posts>(post);
            _postRepo.CreatePost(postModel);
            _postRepo.SaveChanges();

            var postReadDto = _mapper.Map<PostReadDto>(postModel);
            return Ok(new {Id = postReadDto.Id});
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeletePostById(int id)
        {
            var currentPost = await _postRepo.GetPostsByUserIdAsync(id);
            if (currentPost == null)
            {
                return NotFound();
            }

            _postRepo.DeletePostById(id);
            _postRepo.SaveChanges();

            return NoContent();
        }
    }
}
