using Microsoft.AspNetCore.Mvc;
using static System.Net.WebRequestMethods;

namespace SpryStore.PresentationLayer.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.ImageURL = "https://cdn.discordapp.com/attachments/876509239437312070/1088428859269070938/PHOTO-2023-03-23-14-46-03.jpg";
            return View();
        }
    }
}
