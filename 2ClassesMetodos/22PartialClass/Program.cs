using _22PartialClass;

Console.WriteLine("##PARTIAL CLASS##");

//pode ser usado para classes, structs e Enumm

MinhaPartialClass minhaPartialClass = new MinhaPartialClass();

Console.WriteLine("Idade para nascidos 01/01/2000");

var idade = minhaPartialClass.CalculaIdade(new DateTime(2000, 1, 1));
Console.WriteLine($"{Math.Round(idade.TotalDays / 365)} anos");



Console.ReadKey();


