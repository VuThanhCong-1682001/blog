using AutoMapper;
using Ext.Blog.Core.Domain.Identity;

namespace Ext.Blog.Core.Models.System.Role;

public class RoleDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string DisplayName { get; set; }
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<AppRole, RoleDto>();
        }
    }
}
