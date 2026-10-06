using Microsoft.AspNetCore.Mvc;

namespace RestauranteMVC.Controllers;

public class RestauranteController : Controller
{
    public IActionResult Index() => View();
    public IActionResult Cardapio() => View();
    public IActionResult Bebidas() => View();
    public IActionResult Contato() => View();
}
