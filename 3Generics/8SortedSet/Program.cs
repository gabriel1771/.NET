
/*---------------------------------------------*/
//criando
SortedSet<int> numeros = new() { 1, 5, 4, 3, 2 };
Exibir(numeros);

SortedSet<string> frutas = new() { "Uva", "Banana", "Morango" };
Exibir(frutas);

SortedSet<int> pares = new();

for (int i = 7; i > 0; i--)
{
    pares.Add(i * 2);
}

Exibir(pares);

//vindo de outra coleção

List<int> lista = new() { 1, 6, 4, 3, 7, 8 };

SortedSet<int> listaOrdenada = new(lista);

Exibir(listaOrdenada);

Stack<int> comida = new();



Console.ReadKey();

static void Exibir<T>(IEnumerable<T> numeros)
{
    Console.WriteLine();
    foreach (T item in numeros)
    {
        Console.WriteLine(item);
    }
}