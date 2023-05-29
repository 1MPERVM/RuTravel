using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RuTravel.Application.Interfaces;
using RuTravel.Domain;
using RuTravel.Persistence;
using RuTravel.WebApi.DTO;

namespace RuTravel.WebApi.Controllers
{
    [Route("api/comment/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        private readonly ICommentsRepo _commentsRepo;
        private readonly IMapper _mapper;
        public CommentsController(ICommentsRepo commentsRepo, IMapper mapper) => (_commentsRepo, _mapper) = (commentsRepo, mapper);
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CommentReadDto>>> GetAllComments()
        {
            var comments = await _commentsRepo.GetAllCommentsAsync();
            return Ok(_mapper.Map<CommentReadDto>(comments));
        }

        [HttpPost]
        public async Task<ActionResult> CreateComment(CommentCreateDto commentDto)
        {
            var commentModel = _mapper.Map<Comments>(commentDto);
             _commentsRepo.CreateCommentAsync(commentModel);
            _commentsRepo.SaveChangesAsync();

            var commentReadDto = _mapper.Map<CommentReadDto>(commentModel);
            return Ok(new { Id = commentReadDto.Id });
        }

    }
}
