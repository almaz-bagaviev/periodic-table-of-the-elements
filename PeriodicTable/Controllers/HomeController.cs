using Microsoft.AspNetCore.Mvc;

namespace PeriodicTable.Controllers;

public class HomeController : Controller
{
    ChemicalElementsContext context;
    Repository repository;
    DbInitializer initializer;

    public HomeController(ChemicalElementsContext context)
    {
        this.context = context;
        this.repository = new();
        this.initializer = new();
        initializer.Initialize(context);
    }

    public IActionResult Index()
    {      
        return View(repository);
    }
}
