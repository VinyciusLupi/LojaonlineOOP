  Loja loja = new Loja();

        Produto produto1 = new ProdutoFisico("Notebook", 1, 2000.00, 10)
        {
            Peso = 2.5,
            Altura = 0.5,
            Largura = 30,
            Profundidade = 20,
            Desconto = 100 
        };

        Produto produto2 = new ProdutoDigital("Ebook de C#", 2, 50.00, "PDF", 100)
        {
            TamanhoArquivo = 5.0 
        };

        loja.CadastrarProduto(produto1);
        loja.CadastrarProduto(produto2);

        Console.WriteLine("Produtos cadastrados:");
        loja.ListarProdutos();

        Cliente cliente = new Cliente("João Silva", 1, "Rua A, 123", "1234-5678");
        loja.CadastrarCliente(cliente);

        Console.WriteLine("\nClientes cadastrados:");
        loja.ListarClientes();

        Pedido pedido = loja.CriarPedido(cliente.NumeroDeIndentificacao);
        if (pedido != null)
        {
            pedido.AdicionarProduto(produto1);
            pedido.AdicionarProduto(produto2);

            pedido.CalcularTotal();

            loja.FinalizarPedido(pedido);
        }
        Console.WriteLine("\nLista de pedidos:");
        loja.ListarPedidos();