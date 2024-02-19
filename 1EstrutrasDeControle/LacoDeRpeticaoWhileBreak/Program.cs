Console.WriteLine("##INSTRUÇÃO WHILE COM BREAK##");

/*-------------------------------------------------------------------*/

//int numero;

//while (true)
//{
//    Console.WriteLine("informe um numero:     (999paraparar)");
//    numero = Convert.ToInt32(Console.ReadLine());

//    if (numero == 999) break;

//    if(numero % 2 == 0)
//    {
//        Console.WriteLine($"\n{numero} é par\n");
//    }
//    else
//    {
//        Console.WriteLine($"{numero} é impar\n");
//    }
//}



/*-------------------------------------------------------------------*/
//while dentro de um while

int x = 0, y = 0;

while (x < 5)
{
    y = 0;
    while (y < 5)
    {
        Console.Write($"({x},{y}), ");
        y++;
    }
    x++;
    Console.WriteLine();
}



Console.WriteLine("Fim do processamento");