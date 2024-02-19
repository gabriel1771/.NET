Console.WriteLine("##INSTRUÇÃO ELSE-IF-ELSE##");

Console.WriteLine("Digite sua nota: \n");

float nota = Convert.ToSingle(Console.ReadLine());

if(nota < 5)
{
    Console.WriteLine("Reprovado");
}
else if(nota >=5 && nota < 6)
{
    Console.WriteLine("Em recuperação");
}
else if(nota >=6 && nota <= 9)
{
    Console.WriteLine("Aprovado");
}
else if(nota > 9)
{
    Console.WriteLine("Aprovado com diferencial");
}

Console.WriteLine("\n Fim do processamento");

Console.ReadKey();