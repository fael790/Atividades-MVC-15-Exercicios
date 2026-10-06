namespace CursosMVC.Models;

public class Curso
{
    public int Id { get; set; }
    public string Nome { get; set; } = "";
    public int CargaHoraria { get; set; }
    public string Modalidade { get; set; } = "";
    public int Vagas { get; set; }
    public decimal Valor { get; set; }
}
