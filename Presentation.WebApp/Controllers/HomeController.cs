using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Presentation.WebApp.ViewModels.Home;
using System.Diagnostics.Eventing.Reader;
using System.Text;

namespace Presentation.WebApp.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var viewModel = new HomeIndexViewModel();

        ViewData["Title"] = viewModel.Title;
        return View(viewModel);
    }

    //[Route("/")]
    //public async Task<IActionResult> Subscribe()
    //{
    //    var viewModel = new NewsletterViewModel();
    //    return View(viewModel);

    //}

    //[HttpPost]
    //public async Task<IActionResult> Subscribe(HomeIndexViewModel viewModel)
    //{
    //    if (ModelState.IsValid)
    //    {
    //       using var http = new HttpClient();
    //        var url = $"https://localhost:7230/api/subscribers?email={viewModel.Form.Email}";
    //        var request = new HttpRequestMessage(HttpMethod.Post, url);

    //        var response = await http.SendAsync(request);



    //        if (response.IsSuccessStatusCode)
    //        {
    //            viewModel.Form.IsSubscribed = true;
    //        }
    //    }

    //   return RedirectToAction("Index", "Home", "newsletter");
    //}

    [HttpPost]
    public async Task<IActionResult> Index(HomeIndexViewModel viewModel)
    {
        if (ModelState.IsValid)
        //if (viewModel.Form != null)
        {
                try
                {
                    using var http = new HttpClient();
                    var content = new StringContent(JsonConvert.SerializeObject(viewModel.Form), Encoding.UTF8, "application/json");
                    var url = $"https://localhost:7230/api/subscribers";
                    var response = await http.PostAsync(url, content);

                    if (response.IsSuccessStatusCode)
                    {
                        //viewModel.Form.IsSubscribed = true;
                        ViewData["Status"] = "Success";
                    }
                    else if (response.StatusCode == System.Net.HttpStatusCode.Conflict)
                    {
                        ViewData["Status"] = "AlreadyExists";
                    }
                }
                catch
                {
                    ViewData["Status"] = "ConnectionFailed";
                }
        }
        else
        {
            ViewData["Status"] = "Invalid";
        }

        //return RedirectToAction("Index", "Home", "newsletter");
        return View(viewModel);
    }
}
