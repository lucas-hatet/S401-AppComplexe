﻿namespace API_Vinted.Models
{
    public class User
    {
        public string UserName { get; set; }
        public string? FullName { get; set; }
        public string Password { get; set; }
        public string? UserRole { get; set; }
        public int? IDClient { get; set; }

    }
}
