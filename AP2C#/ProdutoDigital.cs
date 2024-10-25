using System.Security.Cryptography.X509Certificates;
public class ProdutoDigital : Produto
{
    public ProdutoDigital(string nome, int codigo, double preco, string formato, int estoque) :base(nome, codigo, preco, estoque)
    {
        Nome = nome;
        Codigo = codigo;
        Preco = preco;
        Formato = formato;
        Estoque = estoque;
    }
   public double TamanhoArquivo { get; set; }
   public string Formato { get; set; }
   public double Desconto = 0.1;
   public override void CalcularPrecoFinal()
   {
    double ValorDesconto = Preco * Desconto;
    double ValorTotal = Preco - ValorDesconto;
   }
}