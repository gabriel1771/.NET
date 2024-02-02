
public class Pessoa
{
    public static int IdadeMinima;

    public int Idade { get; set; }
    public string Nome { get; set; } = string.Empty;

    public Pessoa(int idade, string nome)
    {
        Console.WriteLine("\nExecutando o construtro parametrizado");
        Idade = idade;
        Nome = nome;
    }

    public Pessoa() { }

    static Pessoa()
    {
        Console.WriteLine("\nExecutando o construtor statico");
        Console.WriteLine("\nIinicializando o campo IdadeMinima");
        IdadeMinima = 18;
    }

}