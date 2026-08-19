using Microsoft.AspNetCore.Mvc;

namespace CookiePoisoningLab.Controllers;

public class AdminController : Controller
{
    public ActionResult Index()
    {
        string? role = Request.Cookies["role"];

        if (role != "admin")
        {
            return StatusCode(403);
        }

        return View();
    }
}