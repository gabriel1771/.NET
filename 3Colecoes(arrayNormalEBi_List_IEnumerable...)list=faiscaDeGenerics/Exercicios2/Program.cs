
Console.WriteLine("Informe o numero de valores do array");

int x = Convert.ToInt32(Console.ReadLine());

int[] numeros = new int[x];

do
{
    Console.WriteLine("Informe o numero a se pesquisar no array   (SAIR) para fechar o programa");

    string? keys = Console.ReadLine();

    if (keys.Equals("SAIR")) break;

    int Search = Convert.ToInt32(keys);
    
    int index = Array.BinarySearch(numeros, Search);

    if (index > 0)
    {
        Console.WriteLine("valor encontrado");
    }
    else
    {
        Console.WriteLine("valor não encontrado");
    }

} while (true);

Console.ReadKey();