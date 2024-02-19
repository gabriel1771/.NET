Console.WriteLine("##OPERADORES##");

/*-------------------------------------------------*/
//operadores artmedicos usando as funções nativas da linguagem

Console.WriteLine("Informe o valor de x:");
int x = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Digite o valor y: ");
int y = Convert.ToInt16(Console.ReadLine());

Console.WriteLine($"x + y = {x+y} \n");
Console.WriteLine($"x - y = {x-y} \n");
Console.WriteLine($"x * y = {x*y} \n");
Console.WriteLine($"x / y = {(decimal) x/y} \n");

/*-------------------------------------------------*/
//operadores trigonometricos usando a class Math

Console.WriteLine("\nDigite o valor de W: ");
int W = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("\nAgora digite o valor de Z");
int Z = Convert.ToInt16(Console.ReadLine());

Console.WriteLine($"a raiz quadrada de W é: {Math.Sqrt(W)}\n");
Console.WriteLine($"a W elevador a Z é: {Math.Pow(W, Z)}");
Console.WriteLine($"o cosseno de W é:{Math.Cos(W)}");
Console.WriteLine($"o seno de W é:{Math.Sin(W)}");
Console.WriteLine($"o exponecial de W é:{Math.Exp(W)}");
Console.WriteLine($"valor maximo entre W e Z:{Math.Max(W, Z)}");
Console.WriteLine($"valor minimo entre W e Z:{Math.Min(W,Z)}");

/*-------------------------------------------------*/

Console.ReadKey();