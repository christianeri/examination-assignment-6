namespace WebApp.ViewModels
{
    public class HomeIndexViewModel
    {
        //public ShowcaseViewModel Showcase_1 { get; set; }
        //public ShowcaseViewModel Showcase_2 { get; set; }
        public string Title { get; set; } = "Home";
        public GridCollectionViewModel? BestCollection { get; set; }
        public GridCollectionViewModel? SummerCollection { get; set; }
    }
}
