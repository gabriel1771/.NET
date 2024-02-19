using System.Collections.ObjectModel;

/*---------------------------------------------*/
//criando

/*PRECISA PROTEGER A COLEÇÃO ORIGINAL PORQUE SE ALTERAR ELA AUTOMATICAMENTE ELA ALTERA A DE LEITURA*/

List<string> planetas = new() { "Mercurio", "Venus", "Terra", "Marte" };

ReadOnlyCollection<string> listaPlanetas = new ReadOnlyCollection<string>(planetas);
//ReadOnlyCollection<string> planetas2 = planetas.AsReadOnly();

/*---------------------------------------------*/
//exibindo

foreach ( string item in listaPlanetas)
{
    Console.WriteLine(item);
}

/*---------------------------------------------*/
//tamanho da lista

Console.WriteLine($"tamanho: {listaPlanetas.Count()} itens.");

/*---------------------------------------------*/
//verificar se tem tal item

Console.Write("jupter esta na lista? ");
Console.WriteLine(listaPlanetas.Contains("jupeter") ? "sim" : "não");

/*---------------------------------------------*/
//obtendo através do indice

Console.WriteLine("planeta de index[3]: " + listaPlanetas[3]);

/*---------------------------------------------*/
//obtendo index de um item

Console.WriteLine($"o index da item terra é: {listaPlanetas.IndexOf("Terra")}");

/*---------------------------------------------*/
//alterando a lista original isso se reflete na lista somente leitura

planetas.Insert(4, "Plutão");

foreach (string item in listaPlanetas)
{
    Console.WriteLine(item);
}

/*---------------------------------------------*/
//copiando a lista para um array unidimencional

string[] planetasArray = new string[listaPlanetas.Count + 2];
listaPlanetas.CopyTo(planetasArray, 1); //aqui ele vai copia apartir do index1(então os indexs 0 e 6 não vão ter elementos)

Console.WriteLine();
Console.WriteLine($"tamanho: {listaPlanetas.Count()} itens.");
foreach (string item in planetasArray)
{
    Console.WriteLine($"\"{item}\"");
}

Console.ReadKey();