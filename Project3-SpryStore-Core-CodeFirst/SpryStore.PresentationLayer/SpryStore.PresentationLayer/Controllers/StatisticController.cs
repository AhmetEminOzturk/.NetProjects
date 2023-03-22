using Microsoft.AspNetCore.Mvc;
using SpryStore.DataAccessLayer.Concrete;
using System.Linq;

namespace SpryStore.PresentationLayer.Controllers
{
    public class StatisticController : Controller
    {
        public IActionResult Index()
        {
            Context context = new Context();
            ViewBag.categoryCount = context.Categories.Count();
            ViewBag.productCount = context.Products.Count();
            
            return View();
        }
    }
}
