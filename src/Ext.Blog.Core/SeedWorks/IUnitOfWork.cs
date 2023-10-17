namespace Ext.Blog.Core.SeedWorks
{
    public interface IUnitOfWork
    {
        Task<int> CompleteAsync();
    }
}
