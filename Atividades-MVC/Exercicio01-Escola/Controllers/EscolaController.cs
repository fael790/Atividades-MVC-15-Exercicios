using Microsoft.AspNetCore.Mvc;

namespace EscolaMVC.Controllers;

public class EscolaController : Controller
{
    public IActionResult Index() => View();
    public IActionResult Cursos() => View();
    public IActionResult Contato() => View();
}
