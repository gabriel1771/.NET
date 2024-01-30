Console.WriteLine("##CLASSES E METODOS##");

Pessoa p1 = new Pessoa();

p1.nome = "Maria";
p1.idade = 25;
p1.sexo = "feminino";

//Pessoa p2 = p1;

//pode ser assim
Pessoa p2 = new ();

//ou assim 
// var p2 = new Pessoa();

p2.nome = "Manoel";
p2.idade = 23;
p2.sexo = "mascolino";



Console.WriteLine($"{p1.nome}, {p1.idade}, {p1.sexo}");
Console.WriteLine($"{p2.nome}, {p2.idade}, {p2.sexo}");

Console.ReadKey();


class Pessoa
{
    public string? nome;
    public string? sexo;
    public int idade;
}