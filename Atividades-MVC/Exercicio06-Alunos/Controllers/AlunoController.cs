using Microsoft.AspNetCore.Mvc;
using CadastroAlunosMVC.Models;

namespace CadastroAlunosMVC.Controllers;

public class AlunoController : Controller
{
    public IActionResult Index()
    {
        var alunos = new List<Aluno>
        {
            new() { Id=1, Nome="Ana", Idade=16, Curso="Desenvolvimento de Sistemas" },
            new() { Id=2, Nome="Bruno", Idade=17, Curso="Administração" },
            new() { Id=3, Nome="Carlos", Idade=16, Curso="Desenvolvimento de Sistemas" },
            new() { Id=4, Nome="Daniela", Idade=18, Curso="Mecânica" },
            new() { Id=5, Nome="Eduardo", Idade=17, Curso="Eletricista" },
            new() { Id=6, Nome="Fernanda", Idade=16, Curso="Administração" },
            new() { Id=7, Nome="Gabriel", Idade=18, Curso="Mecânica" },
            new() { Id=8, Nome="Helena", Idade=17, Curso="Desenvolvimento de Sistemas" }
        };
        return View(alunos);
    }

    public IActionResult Detalhes(int id)
    {
        var aluno = new Aluno { Id=id, Nome="Aluno selecionado", Idade=17, Curso="Desenvolvimento de Sistemas" };
        return View(aluno);
    }
}
