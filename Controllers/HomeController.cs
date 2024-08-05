using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Web_PersonalV.Models;

namespace Web_PersonalV.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    public string WebSkin = "normal";

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index(string SkinSeleccionada = "normal")
    {
        WebSkin = SkinSeleccionada;
        ViewBag.Folder = WebSkin;
        return View();
    }

    public IActionResult Stores()
    {
        ViewBag.Folder = WebSkin;
        return View();
    }

    public IActionResult Synthetik()
    {
        ViewBag.Folder = WebSkin;
        return View();
    }

    public IActionResult DevilDaggers()
    {
        ViewBag.Folder = WebSkin;
        return View();
    }

    public IActionResult View4()
    {
        ViewBag.Folder = WebSkin;
        return View();
    }

    public IActionResult Minigame()
    {
        return View();
    }

    public IActionResult SkinSelector()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}