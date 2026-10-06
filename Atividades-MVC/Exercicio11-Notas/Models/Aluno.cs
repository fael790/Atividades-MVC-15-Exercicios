namespace SistemaNotasMVC.Models;

public class Aluno
{
    public int Id { get; set; }
    public string Nome { get; set; } = "";
    public string Curso { get; set; } = "";
    public double Nota1 { get; set; }
    public double Nota2 { get; set; }
    public double Nota3 { get; set; }
    public double Media => (Nota1 + Nota2 + Nota3) / 3;
}
