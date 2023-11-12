using Ext.Blog.Core.Models;
using Ext.Blog.Core.SeedWorks;
using Ext.Blog.Core.Domain.Content;
using Ext.Blog.Core.Models.Content.Posts;
using Ext.Blog.Core.Models.Content.Seri;

namespace Ext.Blog.Core.Repositories
{
    public interface ISeriesRepository : IRepository<Series, Guid>
    {
        Task<PagedResult<SeriesInListDto>> GetAllPaging(string? keyword, int pageIndex = 1, int pageSize = 10);
        Task AddPostToSeries(Guid seriesId, Guid postId, int sortOrder);
        Task RemovePostToSeries(Guid seriesId, Guid postId);
        Task<List<PostInListDto>> GetAllPostsInSeries(Guid seriesId);
        Task<bool> IsPostInSeries(Guid seriesId, Guid postId);
    }
}
