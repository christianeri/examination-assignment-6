namespace WebApp.ViewModels
{
    public class GridCollectionViewModel
    {
        public string? Title { get; set; } = "";
        public IEnumerable<string> Tags { get; set; } = null!;
        public IEnumerable<GridCollectionItemViewModel> GridItems { get; set; } = null!;

        public bool LoadMore { get; set; } = false;
    }
}
