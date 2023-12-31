﻿using Ext.Blog.Core.Domain.Content;
using Ext.Blog.Core.Models;
using Ext.Blog.Core.SeedWorks;
using Ext.Blog.Core.Models.Content.Posts;

namespace Ext.Blog.Core.Repositories
{
    public interface IPostCategoryRepository : IRepository<PostCategory, Guid>
    {
        Task<PagedResult<PostCategoryDto>> GetAllPaging(string? keyword, int pageIndex = 1, int pageSize = 10);
    }
}
