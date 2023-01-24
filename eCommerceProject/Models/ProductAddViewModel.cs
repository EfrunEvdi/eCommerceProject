﻿using Microsoft.AspNetCore.Http;
using System;

namespace eCommerceProject.Models
{
    public class ProductAddViewModel
    {
        
        public string nameProduct { get; set; }
        public string descriptionProduct { get; set; }
        public string brandProduct { get; set; }
        public string sizeProduct { get; set; }
        public Decimal priceProduct { get; set; }
        public int genreCategoryID { get; set; }
        public IFormFile productimageurl1 { get; set; }
        public IFormFile productimageurl2 { get; set; }
        public IFormFile productimageurl3 { get; set; }
        public IFormFile productimageurl4 { get; set; }
        public IFormFile productimageurl5 { get; set; }
        public IFormFile productimageurl6 { get; set; }

    }
}
