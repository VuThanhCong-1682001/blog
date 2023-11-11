using Ext.Blog.Core.Repositories;

namespace Ext.Blog.Core.SeedWorks
{
    public interface IUnitOfWork
    {
        Task<int> CompleteAsync();
        IPostRepository Posts { get; }
        IPostCategoryRepository PostCategories { get; }
    }
}
