using AutoMapper;
using Ext.Blog.Core.Domain.Identity;
using Ext.Blog.Core.Repositories;
using Ext.Blog.Core.SeedWorks;
using Ext.Blog.Data.Repositories;
using Microsoft.AspNetCore.Identity;

namespace Ext.Blog.Data.SeedWorks
{
    public class UnitOfWork : IUnitOfWork   
    {
        private readonly ExtBlogDbContext _context;

        public UnitOfWork(ExtBlogDbContext context, IMapper mapper, UserManager<AppUser> userManager)
        {
            _context = context;
            Series = new SeriesRepository(context, mapper);
            Posts = new PostRepository(context, mapper, userManager);
            PostCategories = new PostCategoryRepository(context, mapper);
        }

        public ISeriesRepository Series { get; private set; }

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
