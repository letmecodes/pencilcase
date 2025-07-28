using Microsoft.AspNetCore.Mvc;

namespace pencilcase.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
