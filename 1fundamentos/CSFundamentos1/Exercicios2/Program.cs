/*---------------------------------------------------------------------------*/
/*//1
string nome = "Paulo";
int idade = 17;
double nota = 7.5;

Console.WriteLine($"{nome} tem {idade} anos e nota {nota}");
Console.WriteLine(nome + " tem " + idade + " anos e nota " + nota);
Console.WriteLine();

*//*---------------------------------------------------------------------------*//*
//2

Console.WriteLine($"nome: {nome} \nidade: {idade}\nnota: {nota}\n");

*//*---------------------------------------------------------------------------*//*
//3

*//*
Para qual tipo de dados você pode converter um float implicitamente ?
( ) int
( x ) double
( ) long
( x ) decimal
*/

/*byte - 1 byte
short – 2 bytes
int – 4 bytes
long – 8 bytes
float – 4 bytes
double – 8 bytes
decimal - 16 bytes
*/

/*---------------------------------------------------------------------------*//*
//4

*//*
Em qual conversão numérica você precisaria realizar o casting (convesão forçada) ?
( ) int para long
( x ) double para long
( x ) double para float
( x ) decimal para float
( x ) long para int
( ) double para decimal
*/

/*---------------------------------------------------------------------------*//*
//5
char letra1, letra2, letra3;

Console.WriteLine("Digite 3 letras uma a baixo da outra:");

letra1 = Convert.ToChar(Console.ReadLine());
letra2 = Convert.ToChar(Console.ReadLine());
letra3 = Convert.ToChar(Console.ReadLine());

Console.WriteLine(""+letra3 + letra2 + letra1);
Console.WriteLine($"{letra3}{letra2}{letra1}");
Console.WriteLine();

*//*---------------------------------------------------------------------------*//*
//6

*//*
Marque verdadeiro(V) ou falso(F) para os códigos abaixo:
( f ) long resultado = 1.32;
( v ) var nome = “Maria”;
( v ) string resultado = 100.ToString();
( v ) A sequência de escape \n inclui uma nova linha
( f ) float f = 5.45;
( v ) decimal valor = (decimal) 10.99f;
( f ) var status = null;
( v ) object o = 12.45m;
( v ) string titulo = true.ToString();
( f ) A sequencia \t inclui uma tabulação vertical
*/

/*---------------------------------------------------------------------------*//*
//7

double x, y;

Console.WriteLine("Digite dois valores um a baixo do outro");

x = Convert.ToDouble(Console.ReadLine());
y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"a soma de {x} com {y} é: {x+y}");
Console.WriteLine($"a subtração de {x} com {y} é: {x-y}");
Console.WriteLine($"a multiplicação de {x} com {y} é: {x*y}");
Console.WriteLine($"a divição de {x} com {y} é: {x/y}");
Console.WriteLine($"a exponenciação de base {x} e expoente {y} é: {Math.Pow(x,y)}");
Console.WriteLine($"o mudulo de {x} por {y} é: {x%y}\n");


*//*---------------------------------------------------------------------------*//*
//8

double a, b, c, n1, n2, delta;

Console.WriteLine("Digite os valores de a, b e c");
a = Convert.ToDouble(Console.ReadLine());
b = Convert.ToDouble(Console.ReadLine());
c = Convert.ToDouble(Console.ReadLine());

delta = Math.Pow(b, 2) - 4 * a * c;

n1 = (-b + Math.Sqrt(delta)) / (2 * a);
n2 = (-b - Math.Sqrt(delta)) / (2 * a);

Console.WriteLine($"As raizes da parabola são: \nX1 = {n1}\nX2 = {delta}");


*//*---------------------------------------------------------------------------*//*
//9

string? login;
int senha;

Console.WriteLine("Digite eu login");
login = Console.ReadLine();
Console.WriteLine("Agora Digite sua senha");
senha = Convert.ToInt32(Console.ReadLine());

string textResultado;

textResultado = ((login == "Maria") || login == "admin") && senha == 123 ? "Login feito com sucesso" : "Logina invalido";

Console.WriteLine(textResultado);

*//*---------------------------------------------------------------------------*//*
//10
*//*Indique verdadeiro(V) ou falso (F) para as seguintes declarações de variáveis considerando
a nomenclatura usada:
( v ) string? nome; é um exemplo de nullable reference type;
( f ) para x igual a 0 , Console.WriteLine(x++); imprime o valor 1
( f ) A ordem de precedência dos operadores lógicos é : ! , || e && (NOT, OR e AND)
( v ) para y igual a 0 , Console.WriteLine(++y); imprime o valor 1
( f ) (10 % 2 == 0) ? “Par” : “Impar”; Vai retornar “Impar”
( f ) Para x=25 e y=5 , a expressão ( y >= x ) && ( y <= x ); retorna true;
( v ) Os nullable reference types emitem um alerta em tempo de compilação para uso do null
( f ) Para x = 10 , o código Console.WriteLine(x+=x); imprime o valor 10;
( f ) Para x = 5, a expressão !(9 >= x) && x <= 7 || x == 5); retorna false;
( v ) O operador ?. permite verificar se um objeto é null e evitar o NullReferenceException
( v ) Qualquer tipo de dado pode ser declarado como anulável com a ajuda do operador "?"
*/

/*---------------------------------------------------------------------------*//*
//11

int x, y;

Console.WriteLine("Digite dois valores:");
x = Convert.ToInt32(Console.ReadLine());
y = Convert.ToInt32(Console.ReadLine());

string respostaX = (x % 2) == 0 ? "x é par" : "x é impar";
string respostaY = (y % 2) == 0 ? "y é par" : "x é impar";

Console.WriteLine(respostaX);
Console.WriteLine(respostaY);
*/
/*---------------------------------------------------------------------------*/
//12

//int x;

//Console.WriteLine("Digite o valor de x");
//x = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine(-6 + x * 5);
//Console.WriteLine((13 - 2) * x);
//Console.WriteLine((x + -2) * (20 / x));
//Console.WriteLine(3 * Math.Pow(x, 2) + x + 10);
//Console.WriteLine(Math.PI * Math.Pow(x, 2));


/*---------------------------------------------------------------------------*/
//13
/*
int y = 5 ;
y = (y++)+y+(++y); ou y = y++ + y + ++y;
Console.WriteLine(y);

vai dar 18, porque o y se altera duas vezes seu valor

*/

/*---------------------------------------------------------------------------*/
//14

//float temperaturaCelcius;

//Console.WriteLine("Digite a temperatura em graus Celcius para ver sua equivalencia eim Kelvin e Farhenheint");

//temperaturaCelcius = Convert.ToSingle(Console.ReadLine());

//float temperaturaKelvin, temperaturaFarhenheit;

//temperaturaKelvin = temperaturaCelcius + 273;
//temperaturaFarhenheit = (temperaturaCelcius * 9) / 5 + 32;

//Console.WriteLine($"As temperaturas em Kelvin e em Farhenheint são respectivamento: {temperaturaKelvin}, {temperaturaKelvin}");

/*---------------------------------------------------------------------------*/
//15

//primeira opção

Console.ReadKey();