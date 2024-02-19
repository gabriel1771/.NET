/*---------------------------------------------*/
//criando uma coleção sortDictionary
SortedDictionary<int, string> brics = new()
{
    {20, "Brasil" },
    {10, "India" },
    {40, "India" },
    {30, "URSS" }
};

/*---------------------------------------------*/
//incluindo novo elemento

if (brics.ContainsKey(70))
{
    Console.WriteLine("Chave ja existe");
}
else
{
    brics.Add(70, "Àfrica do Sul");
}

/*---------------------------------------------*/
//numero de elementos

Console.WriteLine("Numero de paises: " + brics.Count());

/*---------------------------------------------*/
//acessando pela chave
Console.WriteLine(brics[20]);

/*---------------------------------------------*/
//alterado valor

brics[20] = "Argentina";
Console.WriteLine(brics[20]);

/*---------------------------------------------*/
//removendo 

brics.Remove(10);

/*---------------------------------------------*/
//verificando se existe
Console.WriteLine("a chave 30 existe? " + brics.ContainsKey(30));

//pelo valor
Console.WriteLine(" o país Argentina existe? " + brics.ContainsValue("Argentina"));

/*---------------------------------------------*/
//verificando se existe pelo tryget(ele retorna true ou false e se for true ele adiciona o valor a variavel declarada se não adiciona zero ou null nela 

if(brics.TryGetValue(30, out string valor))
{
    Console.WriteLine($"A chave {valor} existe");
}
else
{
    Console.WriteLine("a chave não existe");
}

/*---------------------------------------------*/
//percorrendo 

foreach (KeyValuePair<int, string>  item in brics)
{
    Console.WriteLine(item.Value);
}



Console.ReadKey(); 