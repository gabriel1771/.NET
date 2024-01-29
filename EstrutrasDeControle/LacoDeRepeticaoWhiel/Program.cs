Console.WriteLine("##LAÇO DE REPETIÇÃO WHILE##");

/*-------------------------------------------------------------------*/

//int i = 0;

//while(i < 9)
//{
//    Console.WriteLine($"i: {i}");
//    i++;
//}

/*-------------------------------------------------------------------*/
//valores da tabuada usando a instrução while

int i = 1;

Console.WriteLine("Digite um numero maior que zero:");
int numero = Convert.ToInt32(Console.ReadLine());

if(numero > 0)
{
    while (i <= 10)
    {
        Console.WriteLine($"{numero} X {i} = {numero*i}");
        i++;
    }
}
else
{
    Console.WriteLine("Numero menor que zero.\nFim do processamento");
}



Console.ReadKey();