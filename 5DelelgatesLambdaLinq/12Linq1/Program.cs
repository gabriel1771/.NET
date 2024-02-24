/*EXISTEM DIVERSOS OPERADORES E WHERE É UM DELES*/

/*E TODOS ELES RETORNAM UM IENUMERABLE POR ISSO SE PRECISAR MANIPULAR A COLEÇÃO ALEM DE LER PRECISA CONVERTER PARA LIST = toList() OU ARRAY = toArray() */

//criando uma fonte de dados
List<string> nomes = new() { "joao", "carlinha", "maria", "pedro", "jose" };


/*---------------------------------------------*/
//sintaxe de consulta

//usando uma consulta linq
var nomes1 = from m in nomes
             where m.Contains('o')
             select m;

Exibir(nomes1);
Console.WriteLine();


/*---------------------------------------------*/
//sintax de metodo agr (mais enchuta)

//usando uma consulta linq
var nomes2 = nomes.Where(m => m.Contains('a'));

Exibir(nomes2);

Console.ReadKey();

static void Exibir(IEnumerable<string> nomes1)
{
    foreach (var item in nomes1)
    {
        Console.WriteLine(item);
    }
}