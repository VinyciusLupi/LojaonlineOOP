using System.Reflection.Metadata;

public abstract class Produto
{
    public String Nome { get; set; }
    public int Codigo { get; set; }
    public double Preco{ get; set; }
    public int Estoque { get; set; }
    public Produto (string nome, int codigo, double preco, int estoque)
    {
        Nome = nome;
        Codigo = codigo;
        Preco = preco;
        Estoque = estoque;
    }
    public abstract void CalcularPrecoFinal();
}