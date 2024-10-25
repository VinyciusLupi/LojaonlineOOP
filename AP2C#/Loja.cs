public class Loja 
{
    private List<Produto> produtos;
    private List<Cliente> clientes;
    private List<Pedido> pedidos;

    public Loja()
    {
        produtos = new List<Produto>();
        clientes = new List<Cliente>();
        pedidos = new List<Pedido>();
    }

    public void CadastrarProduto(Produto produto)
    {
        if (produto == null || produtos.Exists(p => p.Codigo == produto.Codigo))
            return;

        produtos.Add(produto);
        Console.WriteLine($"Produto {produto.Nome} cadastrado com sucesso.");
    }

    public Produto ConsultarProdutoPorCodigo(int codigo)
    {
        return produtos.Find(p => p.Codigo == codigo);
    }

    public void ListarProdutos()
    {
        foreach (var produto in produtos)
        {
            Console.WriteLine($"Código: {produto.Codigo}, Nome: {produto.Nome}, Preço: {produto.Preco}, Estoque: {produto.Estoque}");
        }
    }

    public void CadastrarCliente(Cliente cliente)
    {
        if (cliente == null || clientes.Exists(c => c.NumeroDeIndentificacao == cliente.NumeroDeIndentificacao))
            return;

        clientes.Add(cliente);
        Console.WriteLine($"Cliente {cliente.Nome} cadastrado com sucesso.");
    }

    public Cliente ConsultarClientePorID(int id)
    {
        return clientes.Find(c => c.NumeroDeIndentificacao == id);
    }

    public void ListarClientes()
    {
        foreach (var cliente in clientes)
        {
            Console.WriteLine($"ID: {cliente.NumeroDeIndentificacao}, Nome: {cliente.Nome}");
        }
    }

    public  Pedido CriarPedido(int clienteId)
    {
        var cliente = ConsultarClientePorID(clienteId);
        if (cliente == null)
            return null;

        var pedido = new Pedido(cliente);
        pedidos.Add(pedido);
        return pedido;
    }

    public void FinalizarPedido(Pedido pedido)
    {
        if (pedido == null)
            return;

        pedido.FinalizarPedido();
        Console.WriteLine($"Pedido finalizado para o cliente {pedido.cliente.Nome}.");
    }

    public void ListarPedidos()
    {
        foreach (var pedido in pedidos)
        {
            Console.WriteLine($"Pedido para o cliente {pedido.cliente.Nome} Foi Concluido.");
        }
    }
}