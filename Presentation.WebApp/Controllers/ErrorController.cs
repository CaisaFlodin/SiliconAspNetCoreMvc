using Microsoft.AspNetCore.Mvc;
using Presentation.WebApp.ViewModels.Error;

namespace Presentation.WebApp.Controllers
{
    public class ErrorController : Controller
    {
        [Route("/error")]
        public IActionResult PageNotFound()
        {
            var viewModel = new PageNotFoundViewModel();
            return View(viewModel);
        }
    }
}
