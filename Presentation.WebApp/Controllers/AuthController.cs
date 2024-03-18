using Infrastructure.Entities;
using Infrastructure.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Presentation.WebApp.ViewModels.Auth;

namespace Presentation.WebApp.Controllers;

public class AuthController(UserService userService, SignInManager<UserEntity> signInManager, UserManager<UserEntity> userManager) : Controller
{
    private readonly UserService _userService = userService;
    private readonly SignInManager<UserEntity> _signInManager = signInManager;
    private readonly UserManager<UserEntity> _manager = userManager;


    #region Signup
    [Route("/signup")]
    [HttpGet]
    public IActionResult SignUp()
    {
        if (_signInManager.IsSignedIn(User))
            return RedirectToAction("Details", "Account");

        var viewModel = new SignUpViewModel();
        return View(viewModel);
    }

    [Route("/signup")]
    [HttpPost]
    public async Task<IActionResult> SignUp(SignUpViewModel viewModel)
    {
        if (ModelState.IsValid)
        {
            var result = await _userService.CreateUserAsync(viewModel.Form);

            if (result.StatusCode == Infrastructure.Models.StatusCode.OK)
                return RedirectToAction("SignIn", "Auth");

            viewModel.ErrorMessage = result.Message;
            return View(viewModel);
        }
        viewModel.ErrorMessage = "Your password must contain at least: One uppercase letter, one lowercase letter, one number and be a minimum of 8 characters long.";
        return View(viewModel);
    }
    #endregion
}
