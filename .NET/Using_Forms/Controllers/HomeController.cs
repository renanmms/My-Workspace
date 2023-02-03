using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HTML_Tag_Helper.Models;

namespace HTML_Tag_Helper.Controllers;

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

    [HttpPost]
    public IActionResult Index(SportModel model)
    {
        Console.WriteLine($"Nome do esporte: {model.Name}");
        Console.WriteLine($"Anos praticando: {model.Years}");
        Console.WriteLine($"Está participando do torneio: {model.vaiParticiparDoTorneio}");
        return View(model);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
