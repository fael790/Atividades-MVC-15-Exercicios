namespace EstoqueMVC.Models;

public class Produto
{
    public int Id { get; set; }
    public string Nome { get; set; } = "";
    public string Categoria { get; set; } = "";
    public int Estoque { get; set; }
    public int EstoqueMinimo { get; set; }
    public decimal Preco { get; set; }
}
