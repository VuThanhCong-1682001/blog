using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Ext.Blog.Data
{
    public class ExtBlogDbContextFactory : IDesignTimeDbContextFactory<ExtBlogDbContext>
    {
        public ExtBlogDbContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                 .AddJsonFile("appsettings.json")
                 .Build();
            var builder = new DbContextOptionsBuilder<ExtBlogDbContext>();
            builder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            return new ExtBlogDbContext(builder.Options);
        }
    }
}
