
Dictionary<int, int> dic1 = new();
Dictionary<int, int> dic2 = new();

dic2.Add(2, 100);
dic2.Add(4, 400);
dic2.Add(3, 300);

/*---------------------------------------------*/

Dictionary<int, int> dic3 = new() { { 1, 100 }, { 2, 200 }, { 3, 300 } };

/*---------------------------------------------*/

try
{
    dic3.Add(3, 333);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.ToString);
}

bool resultado = dic3.TryAdd(3, 333);
Console.WriteLine("Elemento foi incluido? " + resultado);

/*---------------------------------------------*/
//verificando se tem a chave

if (!dic3.ContainsKey(7))
{
    dic3.Add(7, 7000);
}

/*---------------------------------------------*/
//retornando valor

Console.WriteLine(dic3[7]);

/*---------------------------------------------*/
//verificando se tem o valor

if (dic3.ContainsValue(700))
{
    Console.WriteLine("Esse valor existe!");
}


/*---------------------------------------------*/
//alterando valor 
if (dic3.ContainsKey(7))
{
    dic3[7] = 777;
}

Console.WriteLine($"valor: {dic3[7]} inserido");

/*---------------------------------------------*/
//verificando se existe essa chave para este valor e tratando o erro
try
{
    Console.WriteLine(dic3[5]);
}
catch (Exception ex)
{

    Console.WriteLine(ex.Message); ;
    Console.WriteLine(ex.ToString); ;
}

/*---------------------------------------------*/
//fazendo a mesma coisa porem sem ter exptions para tratar

if (dic3.TryGetValue(5, out int valor))
{
    Console.WriteLine($"A chave que possue o valor {valor} existe");
}
else
{
    Console.WriteLine("varivael não existe");
}

dic3.Add(4, 44444444);

/*---------------------------------------------*/
//percorrendo a o dicionario
foreach (KeyValuePair<int, int> item in dic3)
{
    Console.WriteLine($"chave: {item.Key}, valor: {item.Value}");
}



/*---------------------------------------------*/
//criando um dicionario ordenado pela chaves atraves de um dicionario existente

//var dic3Ordenado = new SortedDictionary<int, int>(dic3);
//SortedDictionary<int, int> dic3Ordenado = new(dic3);

//pelo LINQ agr
 /*System.Linq.*/IOrderedEnumerable< KeyValuePair<int, int>> dic3Ordenado = dic3.OrderBy(x => x.Key);

Console.WriteLine();
foreach (KeyValuePair<int, int> item in dic3Ordenado)
{
    Console.WriteLine($"chave: {item.Key}, valor: {item.Value}");
}



Console.ReadKey();