using Infrastructure.Entities;
using Infrastructure.Models.Courses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace Presentation.WebApp.Controllers;

[Authorize]
public class CoursesController : Controller
{
    //public IActionResult Index()
    //{
    //    var viewModel = new CoursesIndexViewModel();

    //    ViewData["Title"] = viewModel.Title;
    //    return View(viewModel);
    //}
    [HttpGet]
    public async Task<IActionResult> Index()
    {
        ViewData["Title"] = "Courses";

        using var http = new HttpClient();
        var response = await http.GetAsync("https://localhost:7230/api/courses");
        var json = await response.Content.ReadAsStringAsync();
        var data = JsonConvert.DeserializeObject<IEnumerable<CourseEntity>>(json);
        return View(data);
    }

    [HttpGet]
    [Route("/courses/details")]
    public async Task<IActionResult> Details()
    {
        ViewData["Title"] = "Course Details";

        using var http = new HttpClient();
        var response = await http.GetAsync("https://localhost:7230/api/courses/2");
        var json = await response.Content.ReadAsStringAsync();
        var data = JsonConvert.DeserializeObject<CourseEntity>(json);
        return View(data);
    }

    [HttpPost]
    [Route("/courses/details")]
    public async Task<IActionResult> Create(CourseModel model)
    {
        if (ModelState.IsValid)
        {
            using var http = new HttpClient();

            var json = JsonConvert.SerializeObject(model);
            using var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await http.PostAsync($"https://localhost:7230/api/courses/", content);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "Courses");
            }
        }

        return View(model);
    }
}
