﻿namespace Ext.Blog.Core.Models.Auth.Requests
{
    public class TokenRequest
    {
        public required string AccessToken { get; set; }
        public required string RefreshToken { get; set; }
    }
}
