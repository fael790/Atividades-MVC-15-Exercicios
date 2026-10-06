using Microsoft.AspNetCore.Mvc;

namespace CinemaMVC.Controllers;

public class CinemaController : Controller
{
    public IActionResult Index() => View();
    public IActionResult Filmes() => View();
    public IActionResult Ingressos() => View();
}
