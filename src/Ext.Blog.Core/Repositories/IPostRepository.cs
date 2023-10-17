using Ext.Blog.Core.Domain.Content;
using Ext.Blog.Core.SeedWorks;

namespace Ext.Blog.Core.Repositories
{
    public interface IPostRepository : IRepository<Post, Guid>
    {
        Task<List<Post>> GetPopularPostsAsync(int count);
    }
}
