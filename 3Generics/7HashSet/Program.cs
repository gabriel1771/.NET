/*---------------------------------------------*/
//criação

HashSet<int> numeros = new() { 1, 2, 3, 4, 5, 6, 7 };
HashSet<string> frutas = new() { "uva", "banana", "pera"};

HashSet<int> pares = new();
for (int i = 0; i < 6; i++)
{
    pares.Add(i * 2);
}


//criando atraves de uma lista existente, pelo IEnumerable
//qualquer coleção pode ser adicionada: array, lista<string> ...
List<int> lista = new() { 1, 2, 3, 4, 5, 6, 7 };
HashSet<int> conjunto = new(lista);


Console.ReadKey(); 