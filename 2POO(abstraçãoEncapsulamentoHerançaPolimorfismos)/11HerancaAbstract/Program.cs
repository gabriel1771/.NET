
using _11HerancaAbstract;

Quadrado q = new();

Console.WriteLine(q.Descricao());

Console.WriteLine("\nIndorme a cor da figura");

q.Cor = Console.ReadLine();

Console.WriteLine("\nInforme o valor do lado do quadrado");
q.Lado = Convert.ToDouble(Console.ReadLine());

q.CalculaArea();
q.CalculaPerimetro();

Console.WriteLine($"area = {q.Area} ");
Console.WriteLine($"perimetro = {q.Perimetro} ");

Console.WriteLine($"cor = {q.Cor}");

Console.ReadKey();