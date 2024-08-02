namespace test.Modelos;

public class Produto
{
    public Produto(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; set; }
    public string Descricao { get; set; }
    public double PrecoUnitario { get; set; }
    public int Quantidade { get; set; }
}
