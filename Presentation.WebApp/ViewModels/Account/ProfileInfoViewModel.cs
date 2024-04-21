namespace Presentation.WebApp.ViewModels.Account
{
    public class ProfileInfoViewModel
    {
        public string ProfileImage { get; set; } = "profile-image.svg";

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string Email { get; set; } = null!;

        public bool IsExternal { get; set; }

        //public BasicInfoFormViewModel? BasicInfo { get; set; }
    }
}
