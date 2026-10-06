using Microsoft.AspNetCore.Mvc;
using CatalogoProdutosMVC.Models;

namespace CatalogoProdutosMVC.Controllers;

public class ProdutoController : Controller
{
    private List<Produto> Produtos() => new()
    {
        new(){Id=1,Nome="Notebook",Categoria="Informática",Estoque=5,Preco=3500},
        new(){Id=2,Nome="Mouse",Categoria="Informática",Estoque=12,Preco=80},
        new(){Id=3,Nome="Teclado",Categoria="Informática",Estoque=0,Preco=150},
        new(){Id=4,Nome="Monitor",Categoria="Informática",Estoque=3,Preco=900},
        new(){Id=5,Nome="Celular",Categoria="Eletrônicos",Estoque=7,Preco=1800},
        new(){Id=6,Nome="Fone",Categoria="Eletrônicos",Estoque=0,Preco=120},
        new(){Id=7,Nome="Tablet",Categoria="Eletrônicos",Estoque=4,Preco=1100},
        new(){Id=8,Nome="Câmera",Categoria="Eletrônicos",Estoque=2,Preco=2200},
        new(){Id=9,Nome="Webcam",Categoria="Informática",Estoque=6,Preco=250},
        new(){Id=10,Nome="Impressora",Categoria="Informática",Estoque=1,Preco=750}
    };

    public IActionResult Index() => View(Produtos());
    public IActionResult Disponiveis() => View("Index", Produtos().Where(p => p.Estoque > 0).ToList());
}
