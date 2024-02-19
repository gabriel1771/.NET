
int idade = 35;

Console.WriteLine($"a idade é: {idade} \n ");

/*---------------------------------------*/

string nome = "Maria";

Console.WriteLine($"O nome é: {nome}\n");

/*-----------------------------------------*/

double altura = 3.45;

Console.WriteLine($"a altura é: {altura} \n" );

/*------------------------------------------*/

DateTime data = new DateTime(1999, 9, 4);

Console.WriteLine($"a data pedida é: {data.ToShortDateString()} \n");

/*-------------------------------------------*/

const int ANO = 12;

Console.WriteLine(ANO);
Console.WriteLine();

/*--------------------------------------------*/

double? nota = 7.80;
Console.WriteLine(nota);
Console.WriteLine();

/*--------------------------------------------*/

/*
 * os tipos por valor são variaveis que possuem em seu armazenamento seu própio valor e são temporarios(memoria stack)
 * já os tipos por referencia são variaveis que possuem em seu armazenamento o endereço de onde está a variavel que ai então vai ter o valor
 * armazenado e são permanente até que sejam desalocados(memoria heap)
 */

/*--------------------------------------------*/
/*
(int ) x = 10;
(double ) numero = 7.99;
(char ) letra = 'C';
(float ) temperatura = 27.4f;
(bool ) ativo = false;
(string) nome = "Manoel";
(decial ) salario = 950.99m;
(DateTime ) hoje = DateTime.Now;
*/

/*-----------------------------------------------*/

/*
(v ) int n = 1;
(r ) string titulo = "A vida";
(v ) float f = 12.45f;
(v ) double d = 5.45;
(v ) decimal valor = 10.99m;
(v ) char sexo = ‘M’;
(r ) object o = null;
*/

/*--------------------------------------------------*/

/* nullable type é um tipo de valor que aceita valores nulos e por isso
 * pode ser usado em variaveis que precisam estar em null para certas comparações 
*/

/*-----------------------------------------------------*/

//camel case é um padrão de boas praticas de programação, para nomes de variaveis ex: firstName;

/*---------------------------------------------------*/

// pascal case também é um padrão..., para nomes de classes ex: OperacaoArtimedicas;

/*-----------------------------------------*/

int x = 77, y = 66;

int soma = x + y;

Console.WriteLine($"a soma é: {soma} \n");

/*-------------------------------------------*/

/*bool = false
 *char = 0\
 *int = 0
 *double = 0,0
 *float = 0,0f
 *decimal = 0,0m
 *string = null
*/

/*----------------------------------------------*/

/*
(f ) double 1valor = 12.45;
(f ) string #nome = "Pedro";
(v ) float _temperatura = 12.45f;
(f ) double int = 5;
(f ) decimal renda extra = 91.45m;
(f ) bool status$conta = false;
(v ) string titulo3 = “Tópico 1”;
(v ) float salario_mensal = 1999.55f;
(v ) int percentualValorDesconto = 5;
(v ) const bool MENSALIDADE_EM_DIA = true;
*/

/*-----------------------------------------------*/
