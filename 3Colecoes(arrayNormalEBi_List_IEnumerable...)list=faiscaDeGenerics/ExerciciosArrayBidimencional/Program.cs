

string[,] alunos = new string[2, 5];

for (int i = 0; i < alunos.GetLength(0); i++)
{
    for ( int j = 0; j < alunos.GetLength(1); j++)
    {
        Console.WriteLine($"Informe os valores para o campo [{i},{j}]");
        alunos[i, j] = Console.ReadLine();
    }
}

Console.WriteLine("Exibindo os dados dos alunos");

for ( int i = 0; i <alunos.GetLength(0); i++)
{
    for( int j = 0; j < alunos.GetLength(1); j++)
    {
        Console.WriteLine($"Alunos: [{i}, {j}] = {alunos[i,j]}");
    }
}

Console.ReadKey();