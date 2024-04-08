﻿using System.ComponentModel.DataAnnotations;

namespace Api_Task.DTOs
{
    public class ProductDTO
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]

        public string Description { get; set; }
        public int Price { get; set; }
    }
}