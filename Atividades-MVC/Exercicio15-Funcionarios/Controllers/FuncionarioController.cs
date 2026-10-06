using Microsoft.AspNetCore.Mvc;
using FuncionariosMVC.Models;

namespace FuncionariosMVC.Controllers;

public class FuncionarioController : Controller
{
    private List<Funcionario> Funcionarios() => new()
    {
        new(){Id=1,Nome="Ana",Cargo="Analista",Departamento="TI",Salario=4500,Ativo=true},
        new(){Id=2,Nome="Bruno",Cargo="Desenvolvedor",Departamento="TI",Salario=6500,Ativo=true},
        new(){Id=3,Nome="Carlos",Cargo="Assistente",Departamento="RH",Salario=2200,Ativo=false},
        new(){Id=4,Nome="Daniela",Cargo="Gerente",Departamento="RH",Salario=7000,Ativo=true},
        new(){Id=5,Nome="Eduardo",Cargo="Vendedor",Departamento="Vendas",Salario=2800,Ativo=true},
        new(){Id=6,Nome="Fernanda",Cargo="Supervisora",Departamento="Vendas",Salario=5200,Ativo=true},
        new(){Id=7,Nome="Gabriel",Cargo="Auxiliar",Departamento="Financeiro",Salario=2400,Ativo=false},
        new(){Id=8,Nome="Helena",Cargo="Analista",Departamento="Financeiro",Salario=4800,Ativo=true},
        new(){Id=9,Nome="Igor",Cargo="Diretor",Departamento="Diretoria",Salario=10000,Ativo=true},
        new(){Id=10,Nome="Julia",Cargo="Estagiária",Departamento="TI",Salario=1800,Ativo=true},
        new(){Id=11,Nome="Lucas",Cargo="Técnico",Departamento="TI",Salario=3500,Ativo=true},
        new(){Id=12,Nome="Marina",Cargo="Coordenadora",Departamento="RH",Salario=5500,Ativo=true},
        new(){Id=13,Nome="Nicolas",Cargo="Auxiliar",Departamento="Vendas",Salario=2300,Ativo=false},
        new(){Id=14,Nome="Olivia",Cargo="Analista",Departamento="Financeiro",Salario=4200,Ativo=true},
        new(){Id=15,Nome="Pedro",Cargo="Gerente",Departamento="Operações",Salario=7500,Ativo=true}
    };

    public IActionResult Index() => View(Funcionarios());
    public IActionResult Ativos() => View("Index", Funcionarios().Where(f => f.Ativo).ToList());
    public IActionResult Inativos() => View("Index", Funcionarios().Where(f => !f.Ativo).ToList());
    public IActionResult Departamento(string nome = "TI") => View("Index", Funcionarios().Where(f => f.Departamento.Equals(nome, StringComparison.OrdinalIgnoreCase)).ToList());

    public IActionResult Dashboard()
    {
        var f = Funcionarios();
        ViewBag.Total = f.Count;
        ViewBag.Ativos = f.Count(x => x.Ativo);
        ViewBag.Inativos = f.Count(x => !x.Ativo);
        ViewBag.Media = f.Average(x => x.Salario);
        ViewBag.Maior = f.Max(x => x.Salario);
        ViewBag.Menor = f.Min(x => x.Salario);
        ViewBag.Departamentos = f.GroupBy(x => x.Departamento).Select(g => new { Nome = g.Key, Quantidade = g.Count() }).ToList();
        return View();
    }
}
