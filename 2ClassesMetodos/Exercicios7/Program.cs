Console.WriteLine("##EXERCICIO - 07##");



Carro chevrolet = new Carro("Sedan", "Chevrolet", "Onix", 2010, 110);

Carro ford = new Carro("SUV", "Ford", "EcoSport", 2024, 120);

chevrolet.Exibir();

ford.Exibir();


Console.ReadKey();

public class Carro
{
    public string? Modelo;
    public string? Montadora;
    public string? Marca;

    private int ano;
    public int Ano 
    {
        get { return ano;}
        set
        {
            if (value < 2000)
            {
                ano = 2000;
            }else if (value > 2022)
            {
                ano = 2022;
            }
            else
            {
                ano = value;
            }
        }
        
    }

    public int Potencia;

    public Carro(string? Modelo, string? Montadora, string? Marca, int Ano, int Potencia)
    {
        this.Modelo = Modelo;
        this.Marca = Marca;
        this.Montadora = Montadora;
        this.Ano = Ano;
        this.Potencia = Potencia;
    }

    public void Acelerar(string marca)
    {
        Console.WriteLine($"Acelerando meu {marca}");
        Console.WriteLine();
    }

    public void Exibir()
    {
        Console.WriteLine(this.Marca);
        Console.WriteLine(this.Modelo);
        Console.WriteLine(this.Montadora);
        Console.WriteLine(this.Ano);
        Console.WriteLine(this.Potencia + "\n");
    }
}