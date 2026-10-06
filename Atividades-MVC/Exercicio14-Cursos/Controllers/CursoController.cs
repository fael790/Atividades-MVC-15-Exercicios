using Microsoft.AspNetCore.Mvc;
using CursosMVC.Models;

namespace CursosMVC.Controllers;

public class CursoController : Controller
{
    private List<Curso> Cursos() => new()
    {
        new(){Id=1,Nome="Desenvolvimento de Sistemas",CargaHoraria=1200,Modalidade="Presencial",Vagas=20,Valor=0},
        new(){Id=2,Nome="Administração",CargaHoraria=800,Modalidade="Presencial",Vagas=15,Valor=0},
        new(){Id=3,Nome="Excel",CargaHoraria=40,Modalidade="Online",Vagas=30,Valor=150},
        new(){Id=4,Nome="Inglês",CargaHoraria=100,Modalidade="Online",Vagas=0,Valor=200},
        new(){Id=5,Nome="Mecânica",CargaHoraria=1000,Modalidade="Presencial",Vagas=10,Valor=0},
        new(){Id=6,Nome="Python",CargaHoraria=80,Modalidade="Online",Vagas=20,Valor=300},
        new(){Id=7,Nome="Eletricista",CargaHoraria=600,Modalidade="Presencial",Vagas=0,Valor=0},
        new(){Id=8,Nome="Design",CargaHoraria=120,Modalidade="Online",Vagas=12,Valor=250},
        new(){Id=9,Nome="Logística",CargaHoraria=500,Modalidade="Presencial",Vagas=8,Valor=0},
        new(){Id=10,Nome="Banco de Dados",CargaHoraria=80,Modalidade="Online",Vagas=15,Valor=280}
    };
    public IActionResult Index() => View(Cursos());
    public IActionResult Disponiveis() => View("Index", Cursos().Where(c => c.Vagas > 0).ToList());
    public IActionResult Online() => View("Index", Cursos().Where(c => c.Modalidade == "Online").ToList());
    public IActionResult Presenciais() => View("Index", Cursos().Where(c => c.Modalidade == "Presencial").ToList());
}
