using Microsoft.AspNetCore.Mvc;
using BibliotecaMVC.Models;

namespace BibliotecaMVC.Controllers;

public class BibliotecaController : Controller
{
    private List<Livro> Livros() => new()
    {
        new(){Id=1,Titulo="Dom Casmurro",Autor="Machado de Assis",Ano=1899,Disponivel=true},
        new(){Id=2,Titulo="O Cortiço",Autor="Aluísio Azevedo",Ano=1890,Disponivel=false},
        new(){Id=3,Titulo="1984",Autor="George Orwell",Ano=1949,Disponivel=true},
        new(){Id=4,Titulo="O Hobbit",Autor="J.R.R. Tolkien",Ano=1937,Disponivel=true},
        new(){Id=5,Titulo="Harry Potter",Autor="J.K. Rowling",Ano=1997,Disponivel=false},
        new(){Id=6,Titulo="A Revolução dos Bichos",Autor="George Orwell",Ano=1945,Disponivel=true},
        new(){Id=7,Titulo="Capitães da Areia",Autor="Jorge Amado",Ano=1937,Disponivel=false},
        new(){Id=8,Titulo="Vidas Secas",Autor="Graciliano Ramos",Ano=1938,Disponivel=true},
        new(){Id=9,Titulo="O Pequeno Príncipe",Autor="Antoine de Saint-Exupéry",Ano=1943,Disponivel=true},
        new(){Id=10,Titulo="A Moreninha",Autor="Joaquim Manuel de Macedo",Ano=1844,Disponivel=false}
    };
    public IActionResult Index() => View(Livros());
    public IActionResult Disponiveis() => View("Index", Livros().Where(l => l.Disponivel).ToList());
}
