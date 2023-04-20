using WebApp.Models;

namespace WebApp.Services
{
    public class ShowcaseService
    {

        private readonly List<ShowcaseModel> _showcases = new() {
            
            new ShowcaseModel()
            {
                Ingress = "WELCOME TO BMERKETO SHOP",
                Title = "Exclusive Chair gold Collection",
                ImageUrl = "img/placeholders/625x647.svg",
                LinkButton = new LinkButtonModel()
                {
                    Content = "SHOP NOW",
                    Url = "/products",
                }
            },

            new ShowcaseModel()
            {
                Ingress = "BMERKETO SHOP GRAND OPENING",
                Title = "Everything everywhere all at once",
                ImageUrl = "img/placeholders/625x647.svg",
                LinkButton = new LinkButtonModel()
                {
                    Content = "SHOP NOW",
                    Url = "/products",
                }
            }
        };


        public ShowcaseModel GetLatest() 
        { 
            return _showcases.LastOrDefault()!; 
        }
    }
}
