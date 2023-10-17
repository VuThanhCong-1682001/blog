using Ext.Blog.Core.SeedWorks;

namespace Ext.Blog.Data.SeedWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ExtBlogDbContext _context;

        public UnitOfWork(ExtBlogDbContext context)
        {
            _context = context;
        }

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
