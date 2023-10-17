using Ext.Blog.Data;
using Ext.Blog.Data.Data;
using Microsoft.EntityFrameworkCore;

namespace Ext.Blog.API.Configurations
{
    public static class MigrationManager
    {
        public static WebApplication MigrateDatabase(this WebApplication app)
        {
            using (var scope = app.Services.CreateScope())
            {
                using ExtBlogDbContext context = scope.ServiceProvider.GetRequiredService<ExtBlogDbContext>();
                context.Database.Migrate();
                new DataSeeder().SeedAsync(context).Wait();
            }
            return app;
        }
    }
}
