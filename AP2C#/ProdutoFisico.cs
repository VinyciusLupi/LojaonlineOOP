using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;

public class ProdutoFisico : Produto
{
    public ProdutoFisico(string nome, int codigo, double preco, int estoque) :base(nome, codigo, preco, estoque)
    {
        Nome = nome;
        Codigo = codigo;
        Preco = preco;
        Estoque = estoque;
    }
    public double Peso { get; set; } 
    public double Altura { get; set; }
    public double Largura { get; set; }
    public double Profundidade { get; set; }
    public double Categoria { get; set; }
    public double taxadeImposto = 0.1;
    public double Desconto { get; set; }

    public double valorporkg = 40; 
    public override void CalcularPrecoFinal()
    {
        double PrecoImposto = Preco * taxadeImposto;
        double TaxadeEnvio = Peso * valorporkg;
        double ValorTotal = (Preco + PrecoImposto + TaxadeEnvio) - Desconto; 
    }
    
}