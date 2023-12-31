﻿using AutoMapper;
using Ext.Blog.Core.Domain.Content;
using Ext.Blog.Core.Models.Content.Posts;

namespace Ext.Blog.Core.Models.Content
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Post, PostDto>();
            CreateMap<Post, PostInListDto>();
            CreateMap<UpsertPostRequest, Post>();
        }
    }
}
