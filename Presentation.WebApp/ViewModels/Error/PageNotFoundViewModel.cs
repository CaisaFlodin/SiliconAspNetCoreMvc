namespace Presentation.WebApp.ViewModels.Error
{
    public class PageNotFoundViewModel
    {
        public string ImageUrl { get; set; } = null!;
        public string AltText { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string LinkIcon { get; set; } = null!;
        public string LinkText { get; set; } = null!;

        public PageNotFoundViewModel()
        {
            ImageUrl = "/images/404.svg";
            AltText = "Page not found";
            Title = "Ooops!";
            Description = "The page you are looking for is not available.";
            LinkIcon = "fa-regular fa-house";
            LinkText = "Go to homepage";

        }
    }
}
