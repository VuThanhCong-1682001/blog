﻿namespace Ext.Blog.Core.Models.System.Role
{
    public class PermissionDto
    {
        public string RoleId { get; set; }
        public IList<RoleClaimsDto> RoleClaims { get; set; }
    }
}
