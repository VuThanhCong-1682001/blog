using Ext.Blog.Core.Repositories;

namespace Ext.Blog.Core.SeedWorks
{
    public interface IUnitOfWork
    {
        Task<int> CompleteAsync();
        ISeriesRepository Series { get; }
        IPostRepository Posts { get; }
        IPostCategoryRepository PostCategories { get; }
    }
}
