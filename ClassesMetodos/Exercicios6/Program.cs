Console.WriteLine("##EXERCICIOS - 06");

Impostos ipva = new Impostos();

Console.WriteLine("1°" + Impostos.ValorIpva);

ipva.ObterValorIpva();

Console.WriteLine("2°" + Impostos.ValorIpva);

Console.ReadKey();

public class Impostos
{
    public static float ValorIpva;


    public void ObterValorIpva()
    {
        ValorIpva = 4; 
    }
}