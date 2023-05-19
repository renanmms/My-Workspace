using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Ajax_Sample.Models;
using AspNetCoreHero.ToastNotification.Abstractions;

namespace Ajax_Sample.Controllers;

public class HomeController : BaseController
{
    private readonly ILogger<HomeController> _logger;
    private readonly INotyfService _notyfService;
    
    public HomeController(ILogger<HomeController> logger, INotyfService notyfService)
    {
        _notyfService = notyfService;
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public JsonResult ObterFormasPagamento()
    {
        var formasPagamento = new string[]{"Débito", "Crédito", "Dinheiro"};
        return Json(formasPagamento);
    }

    [HttpPost]
    public IActionResult EnviarPedido(PedidoModel model)
    {
        _notyfService.Warning("Enviando pedido...");
        return View("Index");
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
