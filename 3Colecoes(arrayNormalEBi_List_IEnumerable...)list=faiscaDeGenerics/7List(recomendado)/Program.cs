
/*--------------------------------------------------------*/
//declarando uma List<T>

List<string> lista;
lista = new List<string>();

List<int> lista1 = new List<int>();

var lista2 = new List<float>();

//mais usada
List<double> lista3 = new();

/*--------------------------------------------------------*/
//adicionando e declarando dados em uma List<T>

List<string> nomes = new();
nomes.Add("Paulo");
nomes.Add("Maria");

//mais usado 
List<string> lista4 = new() { "Paulo", "Maria", "Bia", "Pedro" };

/*--------------------------------------------------------*/
//adicionando na lista

var lista8 = new List<string>() { "Maria", "Ana", "Pedro", "Carlos", "Zé" };

//adiciona no final
lista8.Add("Marta");

//adicionar na posição 2
lista8.Insert(2, "Bia");

Console.WriteLine(lista.Count + "itens");

/*--------------------------------------------------------*/
//adcionando um array 

List<string> list1 = new() { "Maria", "Pedro", "Ana"};

string[] array1 = { "Diná", "Carlos", "Pedro" };

//adiciona no final da lista
lista.AddRange(array1);

//adiciona apartir da posição informada
lista.InsertRange(1, array1);

Console.WriteLine(lista.Count + " itens");

/*--------------------------------------------------------*/
//Removendo 

List<int> lista5 = new() { 9, 5, 4, 1, 7, 5, 3, 4, 0 };

//removendo o valor fornecido
lista5.Remove(7);

//removendo o valor do indice forncecido
lista5.RemoveAt(4);

//removendo a partir do indice fornecido e a quantidade a ser removido tambem
lista.RemoveRange(0, 2);

/*--------------------------------------------------------*/
//retornando o valor da lista

List<string> lista6 = new() { "Paulo", "Maria", "Bia", "Pedro" };

//acessar um elemento pelo indece
string primeiro = lista6[0];
var quarto = lista6[3];

Console.WriteLine(primeiro);
Console.WriteLine(quarto);

//atribuindo pelo indice(igual um array)
lista6[0] = "ZÉ";
lista6[3] = "Silvia";

Console.WriteLine(lista6[0]);
Console.WriteLine(lista6[3]);


//usando for 
List<string> lista7 = new() { "Paulo", "Maria", "Bia", "Pedro" };

for(int i=0; i<lista.Count; i++)
{
    Console.WriteLine(lista[i]);
}

//usando foreach(mais indicado)

foreach(string item in lista7)
{
    Console.WriteLine(item);
}


/*--------------------------------------------------------*/
//verificando se existe o dados na lista

bool res1 = lista.Contains("Ana");
bool res2 = lista.Contains("Pedro");

Console.WriteLine(res1);
Console.WriteLine(res2);


/*--------------------------------------------------------*/
//ordenando valores com sort e limpando com clear

Console.WriteLine();

ExibirLista(lista7);

lista7.Sort();

ExibirLista(lista7);

lista7.Clear();

ExibirLista(lista7);


Console.ReadKey();

static void ExibirLista(List<string> lista7)
{
    foreach (string item in lista7)
    {
        Console.WriteLine(item);
    }

    Console.WriteLine();
}