

Console.WriteLine("Digite o numero inteirio");
int numero = Convert.ToInt32(Console.ReadLine());

Func<double, double> func = x => Math.Sqrt(x);

Console.WriteLine("A raiz é igual ao " + func(numero));


Console.ReadKey();