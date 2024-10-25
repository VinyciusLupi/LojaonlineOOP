 public class Pedido :  ICarriavel
{
     public Pedido(Cliente cliente)
    {
        this.cliente = cliente;
    }
    private Cliente _cliente;
    public Cliente cliente
    {
    get { return _cliente; }
    set { _cliente = value; }
    }

    public DateTime DataPedido {get; set;}
    public enum Status 
    {
        Processando,
        Concluído,
        Cancelado,
    }

    public List<Produto> ListaProduto = new List<Produto>();
    public Status StatusPedido {get; set;}

    public void AdicionarProduto(Produto produto)
    {
        if (produto == null)
        {
            Console.WriteLine("O produto é nulo.");
        }
        else
        {
        ListaProduto.Add(produto);
        Console.WriteLine("Produto adicionado!");
        }
    }

    public void RemoverProduto(Produto produto)
    {
        if (ListaProduto.Contains(produto))
        {
            ListaProduto.Remove(produto);
        }

        else{
            Console.WriteLine("Produto não encontrato!");
        }

    }

    public void CalcularTotal()
    {
        double Soma = ListaProduto.Sum(produto => produto.Preco); 
    }

    public void FinalizarPedido()
    {
        StatusPedido = Status.Concluído;
    }

}
