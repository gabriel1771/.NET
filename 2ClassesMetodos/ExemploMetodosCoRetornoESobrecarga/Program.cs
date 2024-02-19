Console.WriteLine("##EXEMPLO DE FIXACAO##");

Cadastro cadastro = new Cadastro();

Cliente cliente = cadastro.Registrar();
cadastro.ExibirDados(cliente);

cliente = cadastro.Registrar(cliente);
cadastro.ExibirDados(cliente);

cadastro.ExibirDados("mas algumas informações", cliente);

Console.ReadKey();

public class Cliente
{
    public string? Nome;
    public int Idade;
    public decimal Renda;

    public Cliente(string? nome, int idade, decimal renda)
    {
        Nome = nome;
        Idade = idade;
        Renda = renda;
    }

    public Cliente()
    { }
}

public class Cadastro
{
    public Cliente Registrar()
    {
        Cliente cliente = new Cliente("Maria", 23, 3000);
        return cliente;
    }

    public Cliente Registrar(Cliente cliente)
    {
        cliente.Renda = 3500;
        return cliente;
    }

    public void ExibirDados(Cliente cliente)
    {
        Console.WriteLine($"nome: {cliente.Nome}, idade: {cliente.Idade}, renda: {cliente.Renda}");
        Console.WriteLine();
    }

    public void ExibirDados(string texto, Cliente cliente)
    {
        Console.WriteLine($"nome: {cliente.Nome}, idade: {cliente.Idade}, renda: {cliente.Renda}");
        Console.WriteLine(texto);
        Console.WriteLine();
    }



}