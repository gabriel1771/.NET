using CarroEnum;

Console.WriteLine("##Exercicio - 09##");


Console.WriteLine($"{Cores.Branco} - {(int) Cores.Branco}");
Console.WriteLine($"{Cores.Vermelho} - {(int) Cores.Vermelho}");
Console.WriteLine($"{Cores.Preto} - {(int) Cores.Preto}");
Console.WriteLine($"{Cores.Cinza} - {(int) Cores.Cinza}");
Console.WriteLine($"{Cores.Prata} - {(int) Cores.Prata}");
Console.WriteLine($"{Cores.Azul} - {(int) Cores.Azul}");

Console.WriteLine("\nEscolha dentre as opções à cima: ");
int cor = Convert.ToInt32( Console.ReadLine() );

Carro carro = new Carro(cor);

carro.ExibirInfo();


Console.ReadKey();

