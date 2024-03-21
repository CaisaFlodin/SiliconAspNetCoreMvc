using System.ComponentModel.DataAnnotations;

namespace Presentation.WebApp.ViewModels.Account;

public class AddressInfoFormViewModel
{
    [Display(Name = "Address line 1", Prompt = "Enter your address line", Order = 0)]
    [DataType(DataType.Text)]
    [Required(ErrorMessage = "A valid address line is required")]
    public string AddressLine_1 { get; set; } = null!;

    [Display(Name = "Address line 2 (optional)", Prompt = "Enter your second address line", Order = 1)]
    [DataType(DataType.Text)]
    public string? AddressLine_2 { get; set; }

    [Display(Name = "Postal code", Prompt = "Enter your postal code", Order = 2)]
    [DataType(DataType.PostalCode)]
    [Required(ErrorMessage = "A valid postal code is required")]
    public string PostalCode { get; set; } = null!;

    [Display(Name = "City", Prompt = "Enter your city", Order = 3)]
    [DataType(DataType.Text)]
    [Required(ErrorMessage = "A valid city is required")]
    public string City { get; set; } = null!;
}
