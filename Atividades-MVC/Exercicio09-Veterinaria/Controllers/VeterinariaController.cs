using Microsoft.AspNetCore.Mvc;
using VeterinariaMVC.Models;

namespace VeterinariaMVC.Controllers;

public class VeterinariaController : Controller
{
    private List<Animal> Animais() => new()
    {
        new(){Id=1,Nome="Rex",Especie="Cachorro",Idade=4,Dono="João"},
        new(){Id=2,Nome="Mia",Especie="Gato",Idade=2,Dono="Ana"},
        new(){Id=3,Nome="Thor",Especie="Cachorro",Idade=6,Dono="Carlos"},
        new(){Id=4,Nome="Luna",Especie="Gato",Idade=3,Dono="Mariana"},
        new(){Id=5,Nome="Bob",Especie="Cachorro",Idade=5,Dono="Pedro"},
        new(){Id=6,Nome="Nina",Especie="Gato",Idade=1,Dono="Julia"},
        new(){Id=7,Nome="Max",Especie="Cachorro",Idade=7,Dono="Lucas"},
        new(){Id=8,Nome="Mel",Especie="Gato",Idade=4,Dono="Beatriz"}
    };
    public IActionResult Index() => View(Animais());
    public IActionResult Cachorros() => View("Index", Animais().Where(a => a.Especie == "Cachorro").ToList());
    public IActionResult Gatos() => View("Index", Animais().Where(a => a.Especie == "Gato").ToList());
}
