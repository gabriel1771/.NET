Console.WriteLine("##INSTRUÇÃO DO WHILE##");

/*---------------------------------------------------------*/

//int i = 1;

//do
//{
//    Console.WriteLine($"i = {i}");
//    i++;
//    if (i > 7) break;
//} while (i <= 10);

/*---------------------------------------------------------*/
// do while dentro do outro

int x = 0, y = 0;

do
{
    y = 0;
    do
    {
        Console.Write($"({x},{y}) ");
        y++;
    } while (y < 5);
    x++;
    Console.WriteLine();
} while (x < 5);

Console.WriteLine("Fim do processamento");