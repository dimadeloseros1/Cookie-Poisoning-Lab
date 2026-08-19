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

    
}