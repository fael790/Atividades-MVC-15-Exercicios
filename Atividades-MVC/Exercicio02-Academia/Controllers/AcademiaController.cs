using Microsoft.AspNetCore.Mvc;

namespace AcademiaMVC.Controllers;

public class AcademiaController : Controller
{
    public IActionResult Index() => View();
    public IActionResult Musculacao() => View();
    public IActionResult Cardio() => View();
    public IActionResult Planos() => View();
}
