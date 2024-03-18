using Microsoft.AspNetCore.Mvc;

namespace Presentation.WebApp.Controllers;

public class CoursesController : Controller
{
    //public IActionResult Index()
    //{
    //    var viewModel = new CoursesIndexViewModel();

    //    ViewData["Title"] = viewModel.Title;
    //    return View(viewModel);
    //}
    public IActionResult Index()
    {

        ViewData["Title"] = "Courses";
        return View();
    }

    [Route("/courses/details")]
    public IActionResult Details()
    {
        ViewData["Title"] = "Course Details";
        return View();
    }
}
