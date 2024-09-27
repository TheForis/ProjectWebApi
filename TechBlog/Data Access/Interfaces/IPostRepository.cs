using Domain_Models;

namespace Data_Access.Interfaces
{
    public interface IPostRepository : IRepository<Post>
    {
        Task<PaginatedList> GetPaginatedPosts(int pageIndex);
    }
}
