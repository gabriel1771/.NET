using System.Collections.Concurrent;

Console.WriteLine("##CAMPOS STATICOS##");

ContaCorrente c1 = new();

c1.conta = 123;
c1.Nome = "Maria";
c1.Juros = 2.4f;

ContaCorrente c2 = new();

c2.conta = 321;
c2.Nome = "João";
c2.Juros = 2.1f;

ContaCorrente.PercentualJuros = 0.5f;

Console.WriteLine($"{c1.Nome} tem {c1.JurosAnual()} ao ano");
Console.WriteLine($"{c2.Nome} tem {c2.JurosAnual()} ao ano");

Console.ReadKey();



public class ContaCorrente
{
    public int conta;
    public string? Nome;
    public float Juros;
    public static float PercentualJuros;

    public float JurosAnual()
    {
        float valor = (PercentualJuros + Juros) * 12;
        return valor ;
    }
}