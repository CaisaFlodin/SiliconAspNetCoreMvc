using Microsoft.AspNetCore.Mvc;
using Presentation.WebApp.ViewModels.Courses;

namespace Presentation.WebApp.Controllers;

public class CoursesController : Controller
{
    public IActionResult Index()
    {
        var viewModel = new CoursesIndexViewModel();

        ViewData["Title"] = viewModel.Title;
        return View(viewModel);
    }

    [Route("/courses/details")]
    public IActionResult Details()
    {
        ViewData["Title"] = "Course Details";
        return View();
    }
}
