﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ViewModels
{
    public class CUFoodRequest
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string DiscountType { get; set; }
        public decimal Discount { get; set; }
        public decimal DiscountPrice { get; set; }
        public string? Image { get; set; }
    }
}
