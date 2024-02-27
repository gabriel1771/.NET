Console.WriteLine("Digite um numero inteiro");
int num = Convert.ToInt32(Console.ReadLine());

//Action<int> dobra = delegate (int numero)
//{
//    Console.WriteLine((numero * 2));
//};

Action<int> dobra = x => Console.WriteLine(x * 2);

dobra(num);


Console.ReadKey();