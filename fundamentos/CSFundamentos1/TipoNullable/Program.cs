Console.WriteLine("## TIPO DE DADO NULLABLE ## \n");

//Nullable<int> numero = null;
//Nullable<char> c = null;
//Nullable<bool> condicao = null;

int? numero = null; 
char? c = null;
bool? condicao = null; 

Console.WriteLine(numero);
Console.WriteLine(c);
Console.WriteLine(condicao);
Console.WriteLine();


//ver se é null, se for ai atribui zero se não atribui o valor do nullable para int
int? a = null;
int b = 0;

b = a??0;

Console.WriteLine(b);
Console.WriteLine();

//não pode fazer operações com nullable type com outros tipos de valores ex: int a; int? b; int c = a*b; (isso não pode) tem que ser tudo nullable type 


// 2 funções, 1.se tiver valor no nullable type então retorna um true se não false, 2. retorna o valor
int? valor = null; 

if (valor.HasValue)
{
    Console.WriteLine(valor.Value);
}
else
{
    Console.WriteLine("não possue valor");
}

Console.ReadKey();
