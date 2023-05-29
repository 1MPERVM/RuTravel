using Microsoft.EntityFrameworkCore;
using RuTravel.Application.Interfaces;
using RuTravel.Domain;

namespace RuTravel.Persistence
{
    public class PostsRepo : IPostsRepo
    {
        private readonly RuTravelDBContext _dbContext;
        public PostsRepo(RuTravelDBContext dBContext) => _dbContext = dBContext;
        public async void CreatePost(Posts post)
        {
            if (post == null)
            {
                throw new ArgumentNullException(nameof(post));
            }
            await _dbContext.AddAsync(post);
        }

        public void DeletePostById(int id)
        {
            var currentPost = _dbContext.Posts.FirstOrDefault(p => p.Id == id);
            _dbContext.Posts.Remove(currentPost);
        }

        public async Task<IEnumerable<Posts>> GetPostsByUserIdAsync(int userId) => await _dbContext.Posts.Where(p => p.UsersId == userId).ToListAsync();


        public async void SaveChanges()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
