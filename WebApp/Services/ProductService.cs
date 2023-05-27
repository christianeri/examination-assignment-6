using WebApp.Models.Dtos;
using WebApp.Models.Entities;
using WebApp.Repositories.forDataContext;

namespace WebApp.Services
{
    public class ProductService
    {


        private readonly ProductRepo _productRepo;
        private readonly ProductTagRepo _productTagRepo;
        private readonly IWebHostEnvironment _webHostEnv;
        public ProductService(ProductRepo productRepo, ProductTagRepo productTagRepo, IWebHostEnvironment webHostEnv)
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
        
        public async Task<IEnumerable<ProductDto>> GetAllProductsAsync(int take)
        {
            var items = await _productRepo.GetAllAsync(take);
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
    }
}
