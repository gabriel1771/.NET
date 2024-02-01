Console.WriteLine("##METODOS COM RETORNO##");


Calc calc = new Calc();

int result = calc.Soma(10, 10);

Console.WriteLine(result);

Console.ReadKey();


public class Calc
{
    public int Soma(int n1, int n2)
    {
        return n1 + n2;
    }

    public int subtrair(int n1, int n2)
    {
        return n1 - n2;
    }

    public int produto(int n1, int n2)
    {
        return n1 * n2; 
    }

    public int divisao(int n1, int n2)
    {
        return n1 / n2;
    }
}