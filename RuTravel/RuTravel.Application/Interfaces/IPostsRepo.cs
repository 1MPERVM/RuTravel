using RuTravel.Domain;

namespace RuTravel.Application.Interfaces
{
    public interface IPostsRepo
    {
        void SaveChanges();
        void CreatePost(Posts post);
        void DeletePostById(int id);
        Task<IEnumerable<Posts>> GetPostsByUserIdAsync(int userId);
    }
}
