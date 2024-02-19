
string a = "jose";
string b = "jose";

int x = 100; 
int y = 100;

Console.WriteLine(a.Equals(b));
Console.WriteLine(y.Equals(x));

Pessoa p1 = new(1, "Maria");
Pessoa p2 = new(1, "Maria");

Console.WriteLine(p1.Equals(p2));

Console.ReadKey(); 

public class Pessoa
{

    public string Nome { get; set; }
    public int id { get; set; }

    public Pessoa(int id, string nome)
    {
        this.id = id;
        this.Nome = nome;
    }


}