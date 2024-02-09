

using System.Collections;

/*--------------------------------------------------------*/
//criando e adicionando dados em uma arrayList

//ArrayList lista = new() { "Maria", 5, true, " ", null };

//lista.Add(3.5);

//lista.Insert(1, "Paulo");


/*--------------------------------------------------------*/
//criando e adicionando arrays em uma Arraylist

//ArrayList lista = new() { "Maria", 5, true };

//int[] array1 = { 1, 2, 3 };

//lista.AddRange(array1);

//lista.InsertRange(2, array1);


/*--------------------------------------------------------*/
//Removendo pelo: tipo, posição e a apartir de tal posição avançando tantas posições

//ArrayList lista = new() { "Ana", 5, true, " ", null, 1.1, "Zé", 3, 9, 0 };

//lista.Remove(null);

//lista.RemoveAt(4);

//lista.RemoveRange(2, 2);


/*--------------------------------------------------------*/
//verificando se existe tal dados no arrayList

//var lista1 = new ArrayList() { "Maria", 5, true, 4.5, null, DateTime.Now };

//var res1 = lista1.Contains(5);
//bool res2 = lista1.Contains("Mari");

//Console.WriteLine(res1);
//Console.WriteLine(res2);
//Console.WriteLine(lista1.Contains(null));


/*--------------------------------------------------------*/
//ordenando a lista com metodo Sort

var lista2 = new ArrayList() { "Maria", "Ana", "Zilda", "Carlo", "Diná"};

foreach ( string item in lista2)
{
    Console.Write(item + ", ");
}

Console.WriteLine();

lista2.Sort();

foreach ( var item in lista2)
{
    Console.Write($"{item}, ");
}

/*--------------------------------------------------------*/
//mostrando quantos elementos tem com metodo Count e limpando o mesmo com o metodo Clear

Console.WriteLine("\n\nnumeros de elementos: " + lista2.Count);

lista2.Clear();

Console.WriteLine("\nnumeros de elementos de pois do clear: " + lista2.Count);

Console.ReadKey(); 

