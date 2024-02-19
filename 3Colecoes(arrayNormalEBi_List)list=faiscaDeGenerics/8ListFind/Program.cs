/*-----------------------------------------------*/
//metodo Find espera um predicado(uma função ou metodo que retorna true ou false)
//e ele percorre a lista passando para o predicado cada item 

List<string> frutas = new()
{
    "Uva", "Banana", "Pera", "Maça", "Abacate", "Laranja", "Morango"
};

/*-----------------------------------------------*/
//usando um predicado normal
string? fruta1 = frutas.Find(Procura);
Console.WriteLine(fruta1);


/*-----------------------------------------------*/
//usando um predicado de expressão lambida
string? fruta2 = frutas.Find(i => i.Contains('n'));
Console.WriteLine("Primeira ocorrencia na lista " + fruta2);


/*-----------------------------------------------*/
//a ultima ocorrencia que atenda o criterio estabelecido 

var fruta3 = frutas.FindLast(i => i.Contains('n'));
Console.WriteLine(fruta3);

/*-----------------------------------------------*/
//retorna o indice da primeira ocorrencia do criterio estabelecido

int fruta4 = frutas.FindIndex(i => i.Contains('n'));
Console.WriteLine("indice = " + fruta4 + "  valor = " + frutas[fruta4]);

/*-----------------------------------------------*/
//retorna o indice da ultima ocorrencia do criterio estabelecido

int fruta5 = frutas.FindLastIndex(i => i.Contains('n'));
Console.WriteLine("indice = " + fruta5 + "  valor = " + frutas[fruta5]);


/*-----------------------------------------------*/
//

//List<string> frutas6 = new();
var frutas6 = frutas.FindAll(i => i.Contains('n'));



Console.WriteLine();
foreach ( string item in frutas6)
{
    Console.WriteLine(item);
}

Console.ReadKey();

static bool Procura(string item)
{
    //return item.Contains("n");
    return item.StartsWith('L');
}