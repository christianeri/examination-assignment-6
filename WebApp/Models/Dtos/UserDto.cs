﻿using WebApp.Models.Entities;

namespace WebApp.Models.Dtos
{
    public class UserDto
    {
        public string? Id { get; set; }

        public string? UserName { get; set; }
        
        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? ImageUrl { get; set; }

        public string? Email { get; set; }

        public string? PhoneNumber { get; set; }

        public List<string> Roles { get; set; } = new List<string>();
    }
}
