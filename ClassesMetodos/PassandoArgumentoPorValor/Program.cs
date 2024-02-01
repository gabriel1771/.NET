Console.WriteLine("##PASSANDO POR VALOR##");

int x = 20;

Console.WriteLine("o valor de x é:" + x);

Calculo calculo = new Calculo();

calculo.Dobrando(x);

Console.WriteLine("o valor de x é:" + x);


Console.ReadKey();

public class Calculo
{
    public void Dobrando(int x)
    {
        Console.WriteLine("valor de x:" + (x *= 2)); ;
    }
}
