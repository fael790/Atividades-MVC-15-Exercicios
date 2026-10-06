using Microsoft.AspNetCore.Mvc;
using SistemaNotasMVC.Models;

namespace SistemaNotasMVC.Controllers;

public class AlunoController : Controller
{
    private List<Aluno> Alunos() => new()
    {
        new(){Id=1,Nome="Ana",Curso="DS",Nota1=8,Nota2=7,Nota3=9},
        new(){Id=2,Nome="Bruno",Curso="DS",Nota1=5,Nota2=5,Nota3=4},
        new(){Id=3,Nome="Carlos",Curso="ADM",Nota1=3,Nota2=4,Nota3=2},
        new(){Id=4,Nome="Daniela",Curso="ADM",Nota1=9,Nota2=8,Nota3=10},
        new(){Id=5,Nome="Eduardo",Curso="Mecânica",Nota1=6,Nota2=6,Nota3=6},
        new(){Id=6,Nome="Fernanda",Curso="DS",Nota1=4,Nota2=5,Nota3=4},
        new(){Id=7,Nome="Gabriel",Curso="Mecânica",Nota1=2,Nota2=3,Nota3=3},
        new(){Id=8,Nome="Helena",Curso="DS",Nota1=7,Nota2=7,Nota3=8},
        new(){Id=9,Nome="Igor",Curso="ADM",Nota1=5,Nota2=6,Nota3=5},
        new(){Id=10,Nome="Julia",Curso="DS",Nota1=10,Nota2=9,Nota3=9}
    };
    public IActionResult Index() => View(Alunos());
    public IActionResult Aprovados() => View("Index", Alunos().Where(a => a.Media >= 6).ToList());
    public IActionResult Recuperacao() => View("Index", Alunos().Where(a => a.Media >= 4 && a.Media < 6).ToList());
    public IActionResult Reprovados() => View("Index", Alunos().Where(a => a.Media < 4).ToList());
}
