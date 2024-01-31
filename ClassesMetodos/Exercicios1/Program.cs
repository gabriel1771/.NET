Console.WriteLine("##EXERCICIOS 01##");

/*----------------------------------------------------------*/
//1)

Carro chevrolet = new Carro("Sedan", "Chevrolet", "Onix", 2016, 110);

//chevrolet.Montadora = "Chevrolet";
//chevrolet.Marca = "Onix";
//chevrolet.Modelo = "Sedan";
//chevrolet.Ano = 2016;
//chevrolet.Potencia = 110;

Carro ford = new Carro("SUV", "Ford", "EcoSport", 2018, 120);

//ford.Modelo = "SUV";
//ford.Montadora = "Ford";
//ford.Marca = "EcoSport";
//ford.Ano = 2018;
//ford.Potencia = 120;

chevrolet.Exibir();
chevrolet.Acelerar(chevrolet.Marca == null ? "null" : chevrolet.Marca);

ford.Exibir();
ford.Acelerar(chevrolet.Marca == null ? "null" : chevrolet.Marca);

Console.ReadKey();

public class Carro
{
    public string? Modelo;
    public string? Montadora;
    public string? Marca;
    public int Ano;
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
        Console.WriteLine(this.Potencia);
    }
}