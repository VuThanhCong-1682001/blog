﻿using AutoMapper;
using Ext.Blog.Core.Domain.Identity;

namespace Ext.Blog.Core.Models.System.User
{
    public class CreateUserRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public DateTime? Dob { get; set; }
        public string? Avatar { get; set; }
        public bool IsActive { get; set; }
        public class AutoMapperProfiles : Profile
        {
            public AutoMapperProfiles()
            {
                CreateMap<CreateUserRequest, AppUser>();
            }
        }
    }
}
