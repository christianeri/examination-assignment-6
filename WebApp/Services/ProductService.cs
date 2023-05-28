using Azure;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApp.Models.Dtos;
using WebApp.Models.Entities;
using WebApp.Repositories.forDataContext;

namespace WebApp.Services
{
    public class ProductService
    {


        private readonly ProductRepo _productRepo;
        private readonly ProductTagRepo _productTagRepo;
        private readonly BrandRepo _brandRepo;
        private readonly IWebHostEnvironment _webHostEnv;
        public ProductService(ProductRepo productRepo, ProductTagRepo productTagRepo, IWebHostEnvironment webHostEnv, BrandRepo brandRepo)
        {
            _productRepo = productRepo;
            _productTagRepo = productTagRepo;
            _webHostEnv = webHostEnv;
            _brandRepo = brandRepo;
        }





        public async Task<string> GetBrandNameAsync(int brandId)
        {
            var _entity = await _brandRepo.GetAsync(x => x.Id == brandId);
            if (_entity != null)
            {
                string brandName = _entity.BrandName;
                return brandName;
            }
            return null;
        }        
        
        //public async Task<List<SelectListItem>> GetBrandIdAsync(string selectedBrands)
        //{

        //}




        //här
        public async Task<IEnumerable<ProductDto>> GetAllProductsAsync()
        {
            var items = await _productRepo.GetAllAsync();
            if (items != null)
            {
                var list = new List<ProductDto>();
                foreach (var item in items)
                {
                    list.Add(item);
                }
                foreach (var item in list)
                {
                    item.BrandName = await GetBrandNameAsync(item.BrandId);
                }
                return list;
            }
            return null;
        }          
        
        public async Task<IEnumerable<ProductDto>> GetAllProductsAsync(int take)
        {
            var items = await _productRepo.GetAllAsync(take);
            if (items != null)
            {
                var list = new List<ProductDto>();
                foreach (var item in items) 
                {
                    list.Add(item);
                }
                foreach(var item in list)
                {
                    item.BrandName = await GetBrandNameAsync(item.BrandId);
                }
                return list;
            }
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
            foreach (var item in productDtos)
            {
                item.BrandName = await GetBrandNameAsync(item.BrandId);
            }
            return productDtos;
        } 





        public async Task<ProductDto> GetProductAsync(string articleNumber)
        {
            var _entity = await _productRepo.GetAsync(x => x.ArticleNumber == articleNumber);
            var productDto = new ProductDto();

            if (_entity != null)
            {
                productDto.ArticleNumber = _entity.ArticleNumber;
                productDto.BrandName = await GetBrandNameAsync(_entity.BrandId);
                productDto.BrandId = _entity.BrandId;
                productDto.Description = _entity.Description;
                productDto.ImageUrl = _entity.ImageUrl;
                productDto.Price = _entity.Price;
            }
            return null;
        }





        public async Task<ProductDto> CreateProductAsync(ProductEntity entity)
        {
            var _entity = await _productRepo.GetAsync(x => x.ArticleNumber == entity.ArticleNumber);
            if(_entity == null)
            {
                _entity = await _productRepo.AddAsync(entity);
                if(entity != null)
                    return _entity;
            }
            return null;
        }
        
        public async Task<int> AddBrandAsync(BrandEntity brandEntity)
        {
            var _brandEntity = await _brandRepo.GetAsync(x => x.BrandName == brandEntity.BrandName);
            if (_brandEntity == null)
            {
                _brandEntity = await _brandRepo.AddAsync(brandEntity);
                if (brandEntity != null)
                    return _brandEntity.Id;
            }
            return 0;
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

    }
}
