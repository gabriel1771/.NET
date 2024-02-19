Console.WriteLine("##MÉTODOS STATICOS##");
//metodos da classe e não do objeto


//Calc calc = new Calc();

Console.WriteLine(Calc.Soma(10, 10));
Console.WriteLine(Calc.Subtrair(10, 10));
Console.WriteLine(Calc.Produto(10, 10));
Console.WriteLine(Calc.Divisao(10, 10));

Console.ReadKey();


public class Calc
{
    public static int Soma(int n1, int n2)
    {
        return n1 + n2;
    }

    public static int Subtrair(int n1, int n2)
    {
        return n1 - n2;
    }

    public static int Produto(int n1, int n2)
    {
        return n1 * n2;
    }

    public static int Divisao(int n1, int n2)
    {
        return n1 / n2;
    }
}
