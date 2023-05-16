using Microsoft.EntityFrameworkCore;
using WebApp.Contexts;
using WebApp.Models;
using WebApp.Models.Entities;
using WebApp.Repositories.forDataContext;
using WebApp.ViewModels;

namespace WebApp.Services
{
    public class ProductService
    {


        //private readonly DataContext _context;
        //public ProductService(DataContext context)
        //{
        //    _context = context;
        //}
        //

        private readonly ProductRepository _productRepo;
        private readonly ProductTagRepository _productTagRepo;
        public ProductService(ProductRepository productRepo, ProductTagRepository productTagRepo)
        {
            _productRepo = productRepo;
            _productTagRepo = productTagRepo;
        }





        public async Task<bool> CreateProductAsync(ProductEntity entity)
        {
            var _entity = await _productRepo.GetAsync(x => x.Id == entity.Id);
            if(_entity == null)
            {
                _entity = await _productRepo.AddAsync(entity);
                if(entity != null)
                    return true;
            }
            return false;
        }        
        
        

        
        
        public async Task AddProductTagsAsync(ProductEntity entity, string[] selectedTags)
        {
            foreach (var tag in selectedTags)
            {
                await _productTagRepo.AddAsync(new ProductTagsEntity
                {
                    ProductId = entity.Id,
                    TagId = int.Parse(tag)
                });
            }
        }


        #region obsolete
        /*
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
        */
        #endregion
    }
}
