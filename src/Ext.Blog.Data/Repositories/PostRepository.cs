using Ext.Blog.Core.Domain.Content;
using Ext.Blog.Core.Repositories;
using Ext.Blog.Data.SeedWorks;
using Microsoft.EntityFrameworkCore;

namespace Ext.Blog.Data.Repositories
{
    public class PostRepository : RepositoryBase<Post, Guid>, IPostRepository
    {
        public PostRepository(ExtBlogDbContext context) : base(context)
        {
        }

        public Task<List<Post>> GetPopularPostsAsync(int count)
        {
            return _context.Posts.OrderByDescending(x => x.ViewCount).Take(count).ToListAsync();
        }
    }
}
