namespace WebApp.ViewModels
{
    public class HomeIndexViewModel
    {
        public string Title { get; set; } = "Home";
        public string Heading { get; set; } = "Best Collection";
        public SelectedProductsViewModel? BestCollection { get; set; }
    }
}
