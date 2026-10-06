namespace VeterinariaMVC.Models;

public class Animal
{
    public int Id { get; set; }
    public string Nome { get; set; } = "";
    public string Especie { get; set; } = "";
    public int Idade { get; set; }
    public string Dono { get; set; } = "";
}
