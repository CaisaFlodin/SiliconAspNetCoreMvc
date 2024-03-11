using Microsoft.AspNetCore.Mvc;
using Presentation.WebApp.ViewModels.Home;

namespace Presentation.WebApp.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var viewModel = new HomeIndexViewModel();

        ViewData["Title"] = viewModel.Title;
        return View(viewModel);
    }
}
