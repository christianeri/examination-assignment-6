using Azure;
using System.Linq;
using System.Collections.Generic;
using WebApp.Models.Dtos;
using WebApp.Models.Entities;
using WebApp.Repositories.forDataContext;

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
        private readonly IWebHostEnvironment _webHostEnv;
        public ProductService(ProductRepository productRepo, ProductTagRepository productTagRepo, IWebHostEnvironment webHostEnv)
        {
            _productRepo = productRepo;
            _productTagRepo = productTagRepo;
            _webHostEnv = webHostEnv;
        }





         public async Task<IEnumerable<ProductDto>> GetAllProductsAsync()
        {
            var items = await _productRepo.GetAllAsync();
            var list = new List<ProductDto>();
            foreach (var item in items) 
            {
                list.Add(item);
            }
            return list;
        }         
        
        

        
        
        public async Task<ProductDto> GetProductAsync(string articleNumber)
        {
            var _entity = await _productRepo.GetAsync(x => x.ArticleNumber == articleNumber);
            if (_entity != null)
                return _entity;

            return null;
        }








        public async Task<IEnumerable<ProductDto>> GetSelectedProductsAsync(int[]? selectedTags)
        {

            var list = new List<ProductTagEntity>();
            foreach (var item in selectedTags)
            {
                list = await _productTagRepo.GetSelectedAsync(x => x.TagId == item);
            }
            
            var result = new List<string>();
            foreach (var item in list)
            {
                result.Add(item.ArticleNumber);
            }
            
            var productDtos = new List<ProductDto>();
            foreach (var item in result)
            {
                productDtos.Add(await _productRepo.GetAsync(x => x.ArticleNumber == item));
            }
                       
            return productDtos;


            //var items = await _productRepo.GetAllAsync();
            //var list = new List<ProductDto>();
            //foreach (var item in items)
            //{
            //    list.Add(item);
            //}
            //return list;
        } 



















        //public async Task<bool> CreateProductAsync(ProductEntity entity)
        public async Task<ProductDto> CreateProductAsync(ProductEntity entity)
        {
            var _entity = await _productRepo.GetAsync(x => x.ArticleNumber == entity.ArticleNumber);
            if(_entity == null)
            {
                _entity = await _productRepo.AddAsync(entity);
                if(entity != null)
                    //return true;
                    return _entity;
            }
            //return false;
            return null;
        }        
        
        

        
        
        public async Task AddProductTagsAsync(ProductEntity entity, string[] selectedTags)
        {
            foreach (var tag in selectedTags)
            {
                await _productTagRepo.AddAsync(new ProductTagEntity
                {
                    ArticleNumber = entity.ArticleNumber,
                    TagId = int.Parse(tag)
                });
            }
        }





        public async Task<bool> UploadImageAsync(ProductDto productDto, IFormFile image)
        {
            try
            {
                string productImageFolderPath = $"{_webHostEnv.WebRootPath}/img/productimages/{productDto.ImageUrl}";
                await image.CopyToAsync(new FileStream(productImageFolderPath, FileMode.Create));
                return true;
            }
            catch 
            {
                return false;
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
