Console.WriteLine("##STRUCT##");
//na linguagem C# a unica diferença entra struct e classe é que uma é um ponteiro para o armazenamento heap e a outra é uma variavel no armazenamento stack


Cliente cliente = new Cliente();

cliente.Nome = "Maria";
cliente.Idade = 19;

Console.WriteLine($"{cliente.Nome}, {cliente.Idade}");

Console.ReadKey();

public struct Cliente
{
    public string? Nome { get; set; }
    public int Idade { get; set; }

    public Cliente(string? Nome, int Idade)
    {
        this.Nome = Nome;
        this.Idade = Idade;

    }
}
