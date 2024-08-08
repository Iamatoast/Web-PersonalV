using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Web_PersonalV.Models;

namespace Web_PersonalV.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    public static string WebSkin = "normal";

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.Folder = WebSkin;
        ViewBag.Elementos = Text.PageTxt(WebSkin, "Index");
        return View();
    }

    public IActionResult Stores()
    {
        ViewBag.Folder = WebSkin;
        ViewBag.Elementos = Text.PageTxt(WebSkin, "Stores");
        return View();
    }

    public IActionResult Synthetik()
    {
        ViewBag.Folder = WebSkin;
        ViewBag.Elementos = Text.PageTxt(WebSkin, "Synthetik");
        return View();
    }

    public IActionResult DevilDaggers()
    {
        ViewBag.Folder = WebSkin;
        ViewBag.Elementos = Text.PageTxt(WebSkin, "DevilDaggers");
        return View();
    }

    public IActionResult ItSteals()
    {
        ViewBag.Folder = WebSkin;
        ViewBag.Elementos = Text.PageTxt(WebSkin, "ItSteals");
        return View();
    }

    public IActionResult SkinSelector()
    {
        return View();
    }

    public IActionResult SkinElegida(string SkinSeleccionada)
    {
        WebSkin = SkinSeleccionada;
        ViewBag.Folder = WebSkin;
        ViewBag.Elementos = Text.PageTxt(WebSkin, "Index");
        return View("Index");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}