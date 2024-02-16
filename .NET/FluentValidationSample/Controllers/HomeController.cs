using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FluentValidationSample.Models;
using FluentValidation;
using FluentValidationSample.Validators;

namespace FluentValidationSample.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private PartyValidator _validator;

    public HomeController(
        ILogger<HomeController> logger,
        PartyValidator validator
    )
    {
        _logger = logger;
        _validator = validator;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Sample()
    {
        var party = new Party();
        return View(party);
    }

    [HttpPost]
    public IActionResult Sample(Party party)
    {
        var result = _validator.Validate(party);

        if (!result.IsValid)
        {
            // If validation fails, return the view with validation errors
            return View("Sample", party);
        }

        return RedirectToAction("Index", "Home");
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
