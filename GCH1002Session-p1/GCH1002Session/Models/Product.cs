﻿namespace GCH1002Session.Models
{
    public class Product
    {   
        public int ProductId { get; set; }
        public string ProductName { get; set; }

        public string UrlImage { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

    }
}