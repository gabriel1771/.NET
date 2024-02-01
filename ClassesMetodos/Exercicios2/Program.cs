Console.WriteLine("##EXERCICIOS - 2 ##");

/*----------------------------------------------------------*/
//2)

//a)
Carro fiat = new Carro("Uno", "Fiat");

fiat.Acelerar();

Console.WriteLine($"\nVelocidade = {fiat.PotenciaMaxima(110)}");

Console.ReadKey();

public class Carro
{
    public string? Modelo;
    public string? Montadora;
    public string? Marca;
    public int Ano;
    public int Potencia;

    public Carro(string? Marca, string? Montadora)
    {
        this.Marca = Marca;
        this.Montadora = Montadora;
    }

    public Carro(string? Modelo, string? Montadora, string? Marca, int Ano, int Potencia)
    {
        this.Modelo = Modelo;
        this.Marca = Marca;
        this.Montadora = Montadora;
        this.Ano = Ano;
        this.Potencia = Potencia;
    }

    public void Acelerar()
    {
        Console.WriteLine($"Acelerando meu {this.Marca}");
        Console.WriteLine();
    }

    public void Exibir()
    {
        Console.WriteLine(this.Marca);
        Console.WriteLine(this.Modelo);
        Console.WriteLine(this.Montadora);
        Console.WriteLine(this.Ano);
        Console.WriteLine(this.Potencia);
    }

    public double PotenciaMaxima(int potencia)
    {
        return (potencia * 1.75);
    }
}

