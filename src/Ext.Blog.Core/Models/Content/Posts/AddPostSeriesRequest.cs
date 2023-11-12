namespace Ext.Blog.Core.Models.Content.Posts
{
    public class AddPostSeriesRequest
    {
        public Guid PostId { get; set; }
        public Guid SeriesId { get; set; }
        public int SortOrder { set; get; }
    }
}
