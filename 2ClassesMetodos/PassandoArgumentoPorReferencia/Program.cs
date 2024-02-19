Console.WriteLine("##PASSANDO POR REFERENCIA##");

int x = 20;

Console.WriteLine("o valor de x é:" + x);

Calculo calculo = new Calculo();

calculo.Dobrando(ref x);

Console.WriteLine("o valor de x é:" + x);


Console.ReadKey();

public class Calculo
{
    public void Dobrando(ref int x)
    {
        Console.WriteLine("valor de x:" + (x *= 2)); ;
    }
}
