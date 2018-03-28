﻿using System.ComponentModel.DataAnnotations;

namespace AdminCore.BusinessLogic.Products.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
