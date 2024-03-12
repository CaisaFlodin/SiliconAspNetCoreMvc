using Presentation.WebApp.Models.Components;

namespace Presentation.WebApp.Models.Sections;

public class CoursesModel
{
    public List<string>? Categories { get; set; }
    public List<CoursesDetailsModel> CoursesDetails { get; set; } = null!;
}
