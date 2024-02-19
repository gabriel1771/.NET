/*---------------------------------------------*/
//criando e atribuindo

Queue<string> diaSemana = new();

diaSemana.Enqueue("segunda");
diaSemana.Enqueue("terça");

int[] array = new int[] { 1, 2, 3, 4, 5 };
Queue<int> numeros = new(array);

Queue<int> impares = new(3);
impares.Enqueue(1);

/*---------------------------------------------*/
//contidade
string[] cursos = new string[] { "asp.Net", "HtmlCssJs", "EECORE", "node.js" };
Queue<string> fila = new(cursos);

Console.WriteLine(fila.Count);

Exibir(fila);

/*---------------------------------------------*/
//adicionano

fila.Enqueue(".NET MAUI");
Exibir(fila);

/*---------------------------------------------*/
//obtem mas não remove o item no inicio da fila

string nome = fila.Peek();
Console.WriteLine("\n" + nome);

/*---------------------------------------------*/
//removendo item no inicio da fila

fila.Dequeue();
Exibir(fila);

/*---------------------------------------------*/
//verificando se existe na fila
Console.WriteLine();
Console.WriteLine(fila.Contains("asp.Net"));

/*---------------------------------------------*/
//limpando fila
fila.Clear();
Console.WriteLine("fim");
Exibir(fila);

Console.ReadKey();

static void Exibir<T>(IEnumerable<T> fila)
{
    Console.WriteLine();
    foreach (T item in fila)
    {
        Console.Write($"{item}, ");
    }
}