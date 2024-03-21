using System.ComponentModel.DataAnnotations;

namespace Presentation.WebApp.ViewModels.Account;

public class BasicInfoFormViewModel
{
    public string UserId { get; set; } = null!;

    //[DataType(DataType.ImageUrl)]
    //public string? ProfileImage { get; set; }

    [Display(Name = "First name", Prompt = "Enter your first name", Order = 0)]
    [DataType(DataType.Text)]
    [Required(ErrorMessage = "A valid first name is required")]
    public string FirstName { get; set; } = null!;

    [Display(Name = "Last name", Prompt = "Enter your last name", Order = 1)]
    [DataType(DataType.Text)]
    [Required(ErrorMessage = "A valid last name is required")]
    public string LastName { get; set; } = null!;

    [Display(Name = "Email address", Prompt = "Enter your email address", Order = 2)]
    [DataType(DataType.EmailAddress)]
    [Required(ErrorMessage = "A valid email address is required")]
    [RegularExpression("^[^@\\s]+@[^@\\s]+\\.[^@\\s]{2,}$", ErrorMessage = "Email has to be in format: yourname@example.com")]
    public string Email { get; set; } = null!;

    [Display(Name = "Phone", Prompt = "Enter your phone", Order = 3)]
    [DataType(DataType.PhoneNumber)]
    public string? Phone { get; set; }

    [Display(Name = "Bio (optional)", Prompt = "Add a short bio...", Order = 4)]
    [DataType(DataType.MultilineText)]
    public string? Biography { get; set; }
}
