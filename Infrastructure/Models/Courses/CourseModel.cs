using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Models.Courses;

public class CourseModel
{
    [Required]
    public string Title { get; set; } = null!;

    public string? ImageName { get; set; }

    public string? Author { get; set; }

    public bool IsBestseller { get; set; } = false;

    public int Duration { get; set; }

    [Column(TypeName = "money")]
    public decimal Price { get; set; }

    [Column(TypeName = "money")]
    public decimal DiscountPrice { get; set; }

    public string? LikesInPercent { get; set; }

    public string? LikesInNumbers { get; set; }
}
