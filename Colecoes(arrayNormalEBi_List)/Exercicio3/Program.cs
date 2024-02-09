
float[,] notas = new float[2,5];

float soma1 = 0, soma2 = 0;

for (int i = 0; i< 2; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.WriteLine("Digite valor para a posição notas[" + i + ", " + j + "]");
        notas[i, j] = Convert.ToSingle(Console.ReadLine());

        if (i == 0)
        {
            soma1 += notas[i, j];
        }
        else
        {
            soma2 += notas[i, j];
        }

    }
}

Console.WriteLine($"Media1: {soma1/5}\nMedia2: {soma2/5}");

Console.ReadKey();