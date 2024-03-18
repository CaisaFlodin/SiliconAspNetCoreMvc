using Presentation.WebApp.Models.Components;

namespace Presentation.WebApp.Models.Sections;

public class CoursesModel
{
    public List<string>? Categories { get; set; }
    public ImageViewModel? CourseImage { get; set; }
    public ImageViewModel? Badge { get; set; }
    public string? Icon { get; set; }
    public LinkViewModel? Link { get; set; }
    public string? Title { get; set; }
    public string? Author { get; set; }
    public double? Price { get; set; }
    public double? Discount { get; set; }
    public string? Duration { get; set; }
    public string? Rating { get; set; }
    
    //public List<CoursesDetailsModel> CoursesDetails { get; set; } = [];
}
