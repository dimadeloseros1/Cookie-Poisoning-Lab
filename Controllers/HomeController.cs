using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CookiePoisoningLab.Models;

namespace CookiePoisoningLab.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewBag.UserName = Request.Cookies["username"] ?? "Not logged in";
        ViewBag.role = Request.Cookies["role"] ?? "None";

        return View();
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
