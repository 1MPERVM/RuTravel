using RuTravel.Domain;

namespace RuTravel.Application.Interfaces
{
    public interface ICommentsRepo
    {
        void SaveChangesAsync();
        Task<IEnumerable<Comments>> GetAllCommentsAsync();
        void CreateCommentAsync(Comments comment);
    }
}
