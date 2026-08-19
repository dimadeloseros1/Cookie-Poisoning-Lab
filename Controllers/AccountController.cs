using Microsoft.AspNetCore.Mvc;
using CookiePoisoningLab.Models;

namespace CookiePoisoningLab.Controllers;

public class AccountController : Controller
{
    [HttpGet]
    public ActionResult Login()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Login(LogginViewModel model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }

        string? role = null;

        if (model.UserName == "user" && model.Password == "user")
        {
            role = "user";
        }

        if (model.UserName == "admin" && model.Password == "admin")
        {
            role = "admin";
        }

        if (role == null)
        {
            ModelState.AddModelError("", "Invalid username or password");
        }

        Response.Cookies.Append("username", model.UserName);
        Response.Cookies.Append("role", role);

        return RedirectToAction("Index", "Home");
    }
    
}