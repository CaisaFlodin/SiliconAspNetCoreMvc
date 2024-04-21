using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Entities;

public class CourseEntity
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string? ImageName { get; set; }

    public string? Author { get; set; }

    public bool IsBestseller { get; set; }

    public int Duration { get; set; }

    [Column(TypeName = "money")]
    public decimal Price { get; set; }

    [Column(TypeName = "money")]
    public decimal DiscountPrice { get; set; }

    public string? LikesInPercent { get; set; }

    public string? LikesInNumbers { get; set; }
}
