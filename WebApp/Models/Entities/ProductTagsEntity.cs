﻿using Microsoft.EntityFrameworkCore;
using WebApp.Models.Identity;

namespace WebApp.Models.Entities 
{ 

    [PrimaryKey(nameof(ProductId), nameof(TagId))]
    public class ProductTagsEntity
    {
        public int ProductId { get; set; }
        public ProductEntity Product { get; set; } = null!;

        public int TagId { get; set; }
        public TagEntity Tag { get; set; } = null!;
    }
    
}