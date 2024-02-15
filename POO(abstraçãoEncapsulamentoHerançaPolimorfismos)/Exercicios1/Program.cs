
using Exercicios1;

Carro carro = new(0);

Console.WriteLine("Digite o a quantidade de litros de gasolina para poder dirigir");

if (carro.Abastecer(Convert.ToInt32(Console.ReadLine())))
{
    carro.Dirigir();
}



Console.ReadKey();