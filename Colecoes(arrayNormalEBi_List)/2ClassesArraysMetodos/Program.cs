Console.WriteLine("##CLASSE ARRAYS##");

string[] nome = { "Ana", "Maria", "Dinair", "Paulo", "Carlos", "Beatriz" };

Console.WriteLine("Exibindo arrays");
Exibir(nome);

//inverteu a ordem do array na memoria
Array.Reverse(nome);
Console.WriteLine();
Exibir(nome);

/*-------------------------------------------------------*/

//ordenando um array
Array.Sort(nome);
Console.WriteLine();
Exibir(nome);

/*-------------------------------------------------------*/

//localizando um array, ele retorna o indice
Console.WriteLine();
Console.WriteLine("Digite o nome");
string? palavra = Console.ReadLine();

var indice = Array.BinarySearch(nome, palavra);

if (indice >= 0)
{
    Console.WriteLine("valor encontrado");
    Console.WriteLine(nome[indice] + " - " + indice);
}
else
{
    Console.WriteLine("valor não encontrado");
}

Console.ReadKey();

/*-------------------------------------------------------*/

//função local
static void Exibir(string[] nome)
{
    foreach (var item in nome)
    {
        Console.Write(item + " ");
    }
}