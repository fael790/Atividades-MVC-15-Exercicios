using Microsoft.AspNetCore.Mvc;
using EletronicosMVC.Models;

namespace EletronicosMVC.Controllers;

public class EletronicoController : Controller
{
    private List<Eletronico> Produtos() => new()
    {
        new(){Id=1,Nome="Notebook",Marca="Acer",Categoria="Informática",Preco=3500,Estoque=5},
        new(){Id=2,Nome="Celular",Marca="Samsung",Categoria="Celulares",Preco=1800,Estoque=8},
        new(){Id=3,Nome="TV",Marca="LG",Categoria="Televisão",Preco=2500,Estoque=2},
        new(){Id=4,Nome="Monitor",Marca="AOC",Categoria="Informática",Preco=900,Estoque=0},
        new(){Id=5,Nome="Mouse",Marca="Logitech",Categoria="Informática",Preco=100,Estoque=10},
        new(){Id=6,Nome="Teclado",Marca="Redragon",Categoria="Informática",Preco=220,Estoque=4},
        new(){Id=7,Nome="Fone",Marca="JBL",Categoria="Áudio",Preco=300,Estoque=0},
        new(){Id=8,Nome="Caixa de Som",Marca="JBL",Categoria="Áudio",Preco=450,Estoque=3},
        new(){Id=9,Nome="Tablet",Marca="Lenovo",Categoria="Tablets",Preco=1200,Estoque=6},
        new(){Id=10,Nome="Smartwatch",Marca="Xiaomi",Categoria="Wearables",Preco=500,Estoque=4},
        new(){Id=11,Nome="Webcam",Marca="Intelbras",Categoria="Informática",Preco=250,Estoque=7},
        new(){Id=12,Nome="Impressora",Marca="HP",Categoria="Impressoras",Preco=700,Estoque=1}
    };
    public IActionResult Index() => View(Produtos());
    public IActionResult EmEstoque() => View("Index", Produtos().Where(p => p.Estoque > 0).ToList());
    public IActionResult Categoria(string nome) => View("Index", Produtos().Where(p => p.Categoria.Equals(nome, StringComparison.OrdinalIgnoreCase)).ToList());
    public IActionResult AbaixoDe(decimal valor = 1000) => View("Index", Produtos().Where(p => p.Preco < valor).ToList());
}
