Console.WriteLine("##EXERCICIOS - 08");

Cliente c1 = new Cliente("Maria", "teste@gmail.com", 25);

Cliente.ExibirInfo("Fulano", "teste@gmail.com", 21);
Cliente.ExibirInfo("Ciclano", "teste@gmail.com");


Console.ReadKey();

public struct Cliente
{
    public string Nome;
    public string Email;
    private int idade = 0;
    public int Idade
    {
        get { return idade; }
        set
        {
            if (value < 18)
            {
                idade = 18;
                Console.WriteLine("Cliente menor que 18 anos");
            }
            else
            {
                Console.WriteLine("Cliente maior que 18 anos");
                idade = value;
            }
        }
    }
    public Cliente(string Nome, string Email, int Idade)
    {
        this.Nome = Nome;
        this.Email = Email;
        this.Idade = Idade;
    }

    public static void ExibirInfo(string? Nome, string? Email, int Idade = 18)
    {
        Console.WriteLine($"\n{Nome}\n{Email}\n{Idade}");
    }

}

