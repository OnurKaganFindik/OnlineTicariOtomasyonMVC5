﻿using System.ComponentModel.DataAnnotations;

namespace OnlineTicariOtomasyon.Models.Classes
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Brand { get; set; }
        public short Stock { get; set; }
        public decimal BuyPrice { get; set; }
        public decimal SalePrice { get; set; }
        public bool Status { get; set; }
        public string ProductImgUrl { get; set; }
    }
}