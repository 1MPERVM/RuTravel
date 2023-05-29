using Microsoft.EntityFrameworkCore;
using RuTravel.Application.Interfaces;
using RuTravel.Domain;

namespace RuTravel.Persistence
{
    public class CommentsRepo : ICommentsRepo
    {
        private readonly RuTravelDBContext _dbContext;
        public CommentsRepo(RuTravelDBContext dBContext) => _dbContext = dBContext;

        public async void CreateCommentAsync(Comments comment)
        {
            if (comment == null)
            {
                throw new ArgumentNullException(nameof(comment));
            }
            await _dbContext.Comments.AddAsync(comment);
        }

        public async Task<IEnumerable<Comments>> GetAllCommentsAsync() => await _dbContext.Comments.ToListAsync();

        public async void SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
