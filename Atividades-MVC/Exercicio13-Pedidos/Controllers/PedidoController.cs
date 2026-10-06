using Microsoft.AspNetCore.Mvc;
using PedidosMVC.Models;

namespace PedidosMVC.Controllers;

public class PedidoController : Controller
{
    private List<Pedido> Pedidos() => new()
    {
        new(){Id=1,Cliente="Ana",Produto="X-Burger",Quantidade=2,PrecoUnitario=20,Status="Recebido"},
        new(){Id=2,Cliente="Bruno",Produto="Pizza",Quantidade=1,PrecoUnitario=45,Status="Em preparo"},
        new(){Id=3,Cliente="Carlos",Produto="Batata",Quantidade=2,PrecoUnitario=15,Status="Pronto"},
        new(){Id=4,Cliente="Daniela",Produto="X-Salada",Quantidade=1,PrecoUnitario=22,Status="Entregue"},
        new(){Id=5,Cliente="Eduardo",Produto="Pizza",Quantidade=2,PrecoUnitario=45,Status="Em preparo"},
        new(){Id=6,Cliente="Fernanda",Produto="Suco",Quantidade=3,PrecoUnitario=8,Status="Pronto"},
        new(){Id=7,Cliente="Gabriel",Produto="X-Bacon",Quantidade=1,PrecoUnitario=25,Status="Entregue"},
        new(){Id=8,Cliente="Helena",Produto="Açaí",Quantidade=2,PrecoUnitario=18,Status="Recebido"},
        new(){Id=9,Cliente="Igor",Produto="Pizza",Quantidade=1,PrecoUnitario=45,Status="Pronto"},
        new(){Id=10,Cliente="Julia",Produto="X-Burger",Quantidade=2,PrecoUnitario=20,Status="Entregue"}
    };
    public IActionResult Index() => View(Pedidos());
    public IActionResult EmPreparo() => View("Index", Pedidos().Where(p => p.Status == "Em preparo").ToList());
    public IActionResult Prontos() => View("Index", Pedidos().Where(p => p.Status == "Pronto").ToList());
    public IActionResult Entregues() => View("Index", Pedidos().Where(p => p.Status == "Entregue").ToList());
    public IActionResult Dashboard()
    {
        var pedidos = Pedidos();
        ViewBag.TotalPedidos = pedidos.Count;
        ViewBag.ValorTotal = pedidos.Sum(p => p.Total);
        ViewBag.Recebidos = pedidos.Count(p => p.Status == "Recebido");
        ViewBag.EmPreparo = pedidos.Count(p => p.Status == "Em preparo");
        ViewBag.Prontos = pedidos.Count(p => p.Status == "Pronto");
        ViewBag.Entregues = pedidos.Count(p => p.Status == "Entregue");
        return View();
    }
}
