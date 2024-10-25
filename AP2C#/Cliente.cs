public class Cliente
{
private string nome;

public string Nome
{
    get { return nome; }
    set
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            Console.WriteLine("O campo nome não pode ficar vazio.");
        }
        else
        {
            nome = value;
        }
    }
}
    public int NumeroDeIndentificacao { get; set; }
    public string Endereco { get; set; }
    public string Contato { get; set; }
    public Cliente(string nome, int numerodeindentificacao, string endereco, string contato)
    {
        Nome = nome;
        NumeroDeIndentificacao = numerodeindentificacao;
        Endereco = endereco;
        Contato = contato;
    }
    public void ExibirInfomacoes()
    {
        Console.WriteLine($"Nome do cliente: {Nome},seu numero de indentificação é: {NumeroDeIndentificacao}, seu endereço é: {Endereco}, seu contato é: {Contato}");
    }
}