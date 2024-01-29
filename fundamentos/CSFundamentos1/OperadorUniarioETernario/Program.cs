Console.WriteLine("##OPERADOR UNIARIO E TERNARIO## \n");

/*----------------------------------------------*/
//oparador uniario +(retorna a forma positiva do valor na variavel)
int numero = 1;

Console.WriteLine($"forma positiva da variavel numero: {+numero}");

//operador uniario -(retorna a forma negativa do valor na variavel)
Console.WriteLine($"forma negativa da variavel numero: {-numero}\n");

/*----------------------------------------------*/
//operador ternario(expressão boleana ? executa isso se for true : executa isso se for false)

Console.WriteLine("Digite a temperatura");
var temperatura = Convert.ToDouble(Console.ReadLine());

// poderia ser so isso var resultado = temperatura > 27 ? "quente" : "frio";

var resultado = temperatura >= 27 ? "quente" :
                temperatura < 15 ? "frio" :
                "normal";

Console.WriteLine($"O clima está {resultado}" );

Console.ReadKey();