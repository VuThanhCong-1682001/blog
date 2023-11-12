using System.ComponentModel.DataAnnotations;

namespace Ext.Blog.Core.Models.Content.Posts
{
    public class UpsertPostRequest
    {
        public required string Name { get; set; }

        public required string Slug { get; set; }

        [MaxLength(500)]
        public string? Description { get; set; }

        public string? Thumbnail { get; set; }
        public Guid CategoryId { get; set; }

        public string? Content { get; set; }

        public string? Source { get; set; }

        public string? Tags { get; set; }

        public string? SeoDescription { get; set; }
    }
}
