using System.Threading.Channels;

Console.WriteLine("##PROPIEDADES##");
//atualização da forma de criar os gets and sets
//permite a restrição para a e leitura e gravações do atributos (encapsulamento)

Produto p1 = new();

p1.Nome = "Caderno";
p1.Preco = 4.99;
//p1.Desconto = 0.05;
//p1.PrecoFinal = p1.Preco - p1.Preco *p1.Desconto;
p1.EstoqueMinimo = 10;

p1.Exibir();

Console.ReadKey();

public class Produto
{
    private string? nome;
    public string? Nome 
    {
        get { return nome == null ? "" : nome.ToUpper(); }
        set { nome = value ; }
    }

    private double preco;
    public double  Preco 
    {
        get { return preco;}
        set
        {
            if (value < 5)
            {
                preco = 5;
            }
            else
            {
                preco = value;
            }
        }
    }

    private double desconto = 0.05;
    public double Desconto 
    {
        get { return desconto; } 
    }

    public double PrecoFinal 
    {
        get { return Preco - Preco * Desconto; }
    }

    private int minimo;
    public int EstoqueMinimo 
    {
        set { minimo = value; }
    }

    public void Exibir()
    {
        Console.WriteLine($"{Nome} \n{Preco.ToString("c")} \n{Desconto}" +
                          $"\n{PrecoFinal.ToString("c")} \n{minimo}");
    }
}