using Microsoft.AspNetCore.Mvc;

namespace PeriodicTable.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Repository repository = new();
            
            return View(repository);
        }
    }
}
