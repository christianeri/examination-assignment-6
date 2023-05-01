﻿using Microsoft.EntityFrameworkCore;
using WebApp.Contexts;
using WebApp.Models;
using WebApp.Models.Entities;
using WebApp.ViewModels;

namespace WebApp.Services
{
    public class ProductService
    {


        private readonly DataContext _context;
        public ProductService(DataContext context)
        {
            _context = context;
        }





        public async Task<bool> CreateProductAsync(RegisterProductViewModel registerProductViewModel)
        {
            try
            {
                ProductEntity productEntity = registerProductViewModel;
                _context.Products.Add(productEntity);
                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }




        public async Task<IEnumerable<ProductModel>> GetAllProductsAsync()
        {
            var products = new List<ProductModel>();    
            var items = await _context.Products.ToListAsync();

            foreach (var item in items)
            {
                ProductModel productModel = item;
                products.Add(productModel);
            }
            
            return products;
        }
    }
}
