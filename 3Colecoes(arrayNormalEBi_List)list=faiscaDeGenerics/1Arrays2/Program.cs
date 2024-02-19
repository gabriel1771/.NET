Console.WriteLine("##ARRAY##");

/*----------------------------------------------------------------*/

/*                 aloca, declara, atribui            */

//apenas declarando o array
int[] numeros;
int[] numeros2;

//apenas alocando memoria
numeros = new int[2];

//alocando memoria e atribuindo valor
numeros2 = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//forma diferente de alocar memoria e atribuir valor
string[] nome = { "Ana", "Maria", "Marta", "Paulo", "Carlos" };

//declarando e alocando a memoria
int[] notas = new int[10];

//apenas atribuindo valor
notas[0] = 1;

//declarando, alocando memoria e atribuindo valor
int[] dias = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


/*----------------------------------------------------------------*/



//string[] nomes2 = { "teste", "Ana" };

//Console.WriteLine(nomes2[0]);
//Console.WriteLine(nomes2[1]);

//numeros[0] = 40;

/*----------------------------------------------------------------*/

//for (int i = 0; i < numeros.Length; i++)
//{
//    Console.WriteLine(numeros[i]);
//}

/*----------------------------------------------------------------*/

//foreach (int item in numeros)
//{
//    Console.Write($"{item} ");
//}

foreach (string item in nome)
{
    Console.WriteLine(item);
    if (item == "Marta")
    {
        Console.WriteLine("Login achado com sucesso! Bem vindo Marta");
        break;
    }
 
}  

Console.ReadKey();

