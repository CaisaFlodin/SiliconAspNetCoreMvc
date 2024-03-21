namespace Presentation.WebApp.ViewModels.Account;

public class AccountDetailsViewModel
{
    public string Title { get; set; } = "Account Details";

    public ProfileInfoViewModel? ProfileInfo { get; set; }

    public BasicInfoFormViewModel? BasicInfo { get; set; }

    public AddressInfoFormViewModel? AddressInfo { get; set; } 

    public string? BasicFormMessage { get; set; }

    public string? AddressFormMessage { get; set; }
}
