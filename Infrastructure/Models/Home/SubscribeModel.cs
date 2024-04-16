using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Models.Home;

public class SubscribeModel
{
    [Display(Name = "Daily Newsletter", Order = 0)]
    public bool CheckboxDaily { get; set; } = false;

    [Display(Name = "Event Updates", Order = 1)]
    public bool CheckboxEvent { get; set; } = false;

    [Display(Name = "Advertising Updates", Order = 2)]
    public bool CheckboxAdvertising { get; set; } = false;

    [Display(Name = "Startups Weekly", Order = 3)]
    public bool CheckboxStartups { get; set; } = false;

    [Display(Name = "Week in Review", Order = 4)]
    public bool CheckboxWeek { get; set; } = false;

    [Display(Name = "Podcasts", Order = 5)]
    public bool CheckboxPodcasts { get; set; } = false;

    [Display(Prompt = "Enter your email", Order = 6)]
    [DataType(DataType.EmailAddress)]
    [Required(ErrorMessage = "Email is required")]
    [RegularExpression("^[^@\\s]+@[^@\\s]+\\.[^@\\s]{2,}$", ErrorMessage = "Please enter a valid Email address")]
    public string Email { get; set; } = null!;

    public bool IsSubscribed { get; set; } = false;
}
