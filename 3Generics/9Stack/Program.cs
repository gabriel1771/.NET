/*---------------------------------------------*/
//criando e atribuindo

Stack<int> numeros = new();

numeros.Push(10);
numeros.Push(20);
numeros.Push(30);
numeros.Push(10);


//atraves de outra coleção
int[] array1 = new int[] { 1, 2, 3, 4, 5 };
Stack<int> pilha2 = new(array1);

//segundo cosntruto define o tamanho
Stack<int> pilha3 = new(1);
pilha3.Push(7);

/*---------------------------------------------*/
//exibindo e exibindo seu tamanho

Exibir(numeros);
Console.WriteLine(numeros.Count());

/*---------------------------------------------*/
//retorna sem remover
Console.WriteLine();
Console.WriteLine(numeros.Peek());
Console.WriteLine(numeros.Peek());

/*---------------------------------------------*/
//retornando removendo
Console.WriteLine();
Console.WriteLine(numeros.Pop());
Console.WriteLine(numeros.Pop());

Exibir(numeros);

/*---------------------------------------------*/
//verificando se existe 
Console.WriteLine();
Console.WriteLine(numeros.Contains(30));

/*---------------------------------------------*/
//copia
Stack<int> copia = new(numeros.ToArray());
Exibir(copia);


/*---------------------------------------------*/
//excluir

numeros.Clear();
Console.WriteLine("fim");
Exibir(numeros);

Console.ReadKey();

static void Exibir<T>(IEnumerable<T> numeros)
{
    Console.WriteLine();
    foreach (T item in numeros)
    {
        Console.WriteLine(item);
    }
}