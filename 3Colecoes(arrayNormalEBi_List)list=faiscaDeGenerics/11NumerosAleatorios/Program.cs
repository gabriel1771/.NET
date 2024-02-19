
/*-----------------------------------------------*/

Random random = new();

//numeros aleatorios
Console.WriteLine(random.Next());

//numeros aleatorios até 20
Console.WriteLine(random.Next(20));

//numeros entre esses dois valores
Console.WriteLine(random.Next(10, 20));

//numeros entre 0 e 1
Console.WriteLine(random.NextDouble());

/*------------------------------------------------*/

//array que suporta sumeros entre 0 e 255 de ocacionalmente 10 posições
byte[] randByte = new byte[10];

Random random2 = new(2023); //aqui estou usando uma semente qualquer

//aqui eu estou preenchendo esse array com numeros aleatorios entre 0 a 255
random2.NextBytes(randByte);

/*------------------------------------------------*/
//exemplo pratico

Console.WriteLine("Sorteio da MegaSena\n");

Random random0 = new Random();

int[] numerosSorteados = new int[7]; 

for (int i = 0; i < 7; i++)
{
    int numeroAleatorio;

    do
    {
        numeroAleatorio = random.Next(1, 61);
    } while (numerosSorteados.Contains(numeroAleatorio));

    numerosSorteados[i] = numeroAleatorio;

}

Array.Sort(numerosSorteados);

Console.WriteLine("Numeros Sorteados\n");

Console.WriteLine( string.Join(" ", numerosSorteados));


Console.ReadKey();