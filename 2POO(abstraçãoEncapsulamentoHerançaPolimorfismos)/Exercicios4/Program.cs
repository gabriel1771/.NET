
using Exercicios4;

Pessoa[] pessoas = new Pessoa[3];

for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Digite o nome:");
    pessoas[i] = new Pessoa();
    ((Pessoa)pessoas[i]).Nome = Console.ReadLine();

}

foreach ( Pessoa item in pessoas)
{
    Console.WriteLine(item.ToString()); ;
}

Console.ReadKey();