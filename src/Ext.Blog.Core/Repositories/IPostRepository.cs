using Ext.Blog.Core.Domain.Content;
using Ext.Blog.Core.Models.Content;
using Ext.Blog.Core.Models;
using Ext.Blog.Core.SeedWorks;

namespace Ext.Blog.Core.Repositories
{
    public interface IPostRepository : IRepository<Post, Guid>
    {
        Task<List<Post>> GetPopularPostsAsync(int count);
        Task<PagedResult<PostInListDto>> GetPostsPagingAsync(string keyword, Guid? categoryId, int pageIndex = 1, int pageSize = 10);
    }
}
