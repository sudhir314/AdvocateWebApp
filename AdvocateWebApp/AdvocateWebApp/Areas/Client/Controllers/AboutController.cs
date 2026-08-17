using Microsoft.AspNetCore.Mvc;

namespace AdvocateWebApp.Areas.Client.Controllers
{
    [Area("Client")]
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            // Page Title set karein jo layout mein render hoga
            ViewData["Title"] = "About Sharma & Associates | Advocates";
            return View();
        }
    }
}
