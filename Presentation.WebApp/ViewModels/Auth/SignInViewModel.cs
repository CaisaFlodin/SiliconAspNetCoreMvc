using Infrastructure.Models;

namespace Presentation.WebApp.ViewModels.Auth
{
    public class SignInViewModel
    {
        public string Title { get; set; } = "Sign In";
        public SignInModel Form { get; set; } = new SignInModel();
        public string? ErrorMessage { get; set; }
    }
}
