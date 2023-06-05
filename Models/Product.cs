﻿using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace E_commerce.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string? ProductName { get; set; }
        public string? category { get; set; }
        public string?  Color { get; set; }
        public decimal Price { get; set; }
        public string? AvatarUrl { get; set; }
    }
}
