using System.Security.Principal;

Console.WriteLine("##SOMA DE NUMEROS INTEIROS##");

int[] valores = { 1, 2, 3, 4, 5};

//int resultado = Calcular.Soma(new int[] {10, 20, 30});
int resultado = Calcular.Soma(10, 20, 30, 40, 50);

Console.WriteLine(resultado);

Console.ReadKey();



public class Calcular
{
    public static int Soma(params int[] numeros)
    {
        int total = 0;

        foreach (int item in numeros)
        {
            total += item;
        }

        return total;
    }
}