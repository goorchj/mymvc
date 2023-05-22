using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using mymvc.Models;

namespace mymvc.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult About()
    {
        return View();
    }
     public IActionResult cart()
    {
        return View();
    }
     public IActionResult checkout()
    {
        return View();
    }
     public IActionResult contact()
    {
        return View();
    }
     public IActionResult faq()
    {
        return View();
    }
     public IActionResult order()
    {
        return View();
    }
     public IActionResult Product()
    {
        return View();
    }
      public IActionResult Login()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
