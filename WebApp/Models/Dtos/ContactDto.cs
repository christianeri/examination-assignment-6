﻿namespace WebApp.Dtos
{
    public class ContactDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string Organization { get; set; } = null!;
        public string Message { get; set; } = null!;
    }
}
