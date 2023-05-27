using Azure;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using WebApp.Models.Dtos;
using WebApp.Repositories.forDataContext;

namespace WebApp.Services
{
    public class TagService
    {

        private readonly TagRepo _tagRepo;
        private readonly ProductTagRepo _productTagRepo;
        public TagService(TagRepo tagRepo, ProductTagRepo productTagRepo)
        {
            _tagRepo = tagRepo;
            _productTagRepo = productTagRepo;
        }





        public async Task<List<SelectListItem>> GetTagsAsync()
        {
            var tags = new List<SelectListItem>();

            foreach(var tag in await _tagRepo.GetAllAsync())
            {
                tags.Add(new SelectListItem
                {
                    Value = tag.Id.ToString(),
                    Text = tag.TagName
                });
            }
            return tags;
        }        
        
        
        public async Task<List<SelectListItem>> GetTagsAsync(string articleNumber)
        {
            var requestedTags = new List<int>();
            foreach (var tags in await _productTagRepo.GetSelectedAsync(x => x.ArticleNumber == articleNumber))
            {
                requestedTags.Add(tags.TagId);
            }

            var associatedTags = new List<SelectListItem>();
            //foreach (var tagId in requestedTags)
            //{

            //}

            foreach (var tag in await _tagRepo.GetAllAsync())
            {
                associatedTags.Add(new SelectListItem
                {
                    Value = tag.Id.ToString(),
                    Text = tag.TagName,
                    Selected = requestedTags!.Contains(tag.Id)
                });
            }
            return associatedTags;

        }
        

      
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        public async Task<List<SelectListItem>> GetTagsAsync(string[] selectedTags)
        {
            var tags = new List<SelectListItem>();

            foreach (var tag in await _tagRepo.GetAllAsync())
            {
                tags.Add(new SelectListItem
                {
                    Value = tag.Id.ToString(),
                    Text = tag.TagName,
                    Selected = selectedTags!.Contains(tag.Id.ToString())
                });
            }
            return tags;
        }
    }
}
