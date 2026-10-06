using Microsoft.AspNetCore.Mvc;

namespace HotelMVC.Controllers;

public class HotelController : Controller
{
    public IActionResult Index() => View();
    public IActionResult Quartos() => View();
    public IActionResult Servicos() => View();
    public IActionResult Contato() => View();
}
