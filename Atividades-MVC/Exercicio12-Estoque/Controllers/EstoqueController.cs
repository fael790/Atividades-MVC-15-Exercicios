using Microsoft.AspNetCore.Mvc;
using EstoqueMVC.Models;

namespace EstoqueMVC.Controllers;

public class EstoqueController : Controller
{
    private List<Produto> Produtos() => new()
    {
        new(){Id=1,Nome="Arroz",Categoria="Alimentos",Estoque=0,EstoqueMinimo=5,Preco=25},
        new(){Id=2,Nome="Feijão",Categoria="Alimentos",Estoque=3,EstoqueMinimo=5,Preco=8},
        new(){Id=3,Nome="Macarrão",Categoria="Alimentos",Estoque=15,EstoqueMinimo=5,Preco=6},
        new(){Id=4,Nome="Café",Categoria="Alimentos",Estoque=4,EstoqueMinimo=5,Preco=15},
        new(){Id=5,Nome="Açúcar",Categoria="Alimentos",Estoque=20,EstoqueMinimo=5,Preco=5},
        new(){Id=6,Nome="Detergente",Categoria="Limpeza",Estoque=0,EstoqueMinimo=3,Preco=3},
        new(){Id=7,Nome="Sabão",Categoria="Limpeza",Estoque=2,EstoqueMinimo=3,Preco=10},
        new(){Id=8,Nome="Papel",Categoria="Limpeza",Estoque=12,EstoqueMinimo=4,Preco=12},
        new(){Id=9,Nome="Shampoo",Categoria="Higiene",Estoque=8,EstoqueMinimo=3,Preco=18},
        new(){Id=10,Nome="Sabonete",Categoria="Higiene",Estoque=1,EstoqueMinimo=5,Preco=4},
        new(){Id=11,Nome="Creme Dental",Categoria="Higiene",Estoque=10,EstoqueMinimo=3,Preco=7},
        new(){Id=12,Nome="Desinfetante",Categoria="Limpeza",Estoque=5,EstoqueMinimo=4,Preco=9},
        new(){Id=13,Nome="Esponja",Categoria="Limpeza",Estoque=0,EstoqueMinimo=4,Preco=3},
        new(){Id=14,Nome="Farinha",Categoria="Alimentos",Estoque=7,EstoqueMinimo=5,Preco=6},
        new(){Id=15,Nome="Leite",Categoria="Alimentos",Estoque=3,EstoqueMinimo=5,Preco=5}
    };
    public IActionResult Index() => View(Produtos());
    public IActionResult Baixo() => View("Index", Produtos().Where(p => p.Estoque > 0 && p.Estoque <= p.EstoqueMinimo).ToList());
    public IActionResult Esgotados() => View("Index", Produtos().Where(p => p.Estoque == 0).ToList());
    public IActionResult Alertas() => View("Index", Produtos().Where(p => p.Estoque <= p.EstoqueMinimo).ToList());
}
