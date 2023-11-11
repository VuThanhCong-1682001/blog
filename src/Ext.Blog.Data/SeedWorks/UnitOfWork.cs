using AutoMapper;
using Ext.Blog.Core.Repositories;
using Ext.Blog.Core.SeedWorks;
using Ext.Blog.Data.Repositories;

namespace Ext.Blog.Data.SeedWorks
{
    public class UnitOfWork : IUnitOfWork   
    {
        private readonly ExtBlogDbContext _context;

        public UnitOfWork(ExtBlogDbContext context, IMapper mapper)
        {
            _context = context;
            Posts = new PostRepository(context, mapper);
            PostCategories = new PostCategoryRepository(context, mapper);
        }
        
        public IPostRepository Posts { get; private set; }

        public IPostCategoryRepository PostCategories { get; private set; }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
