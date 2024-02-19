Console.WriteLine("##EXERCICIOS - 04");

double potencia = 1;

Carro carro = new();

Console.WriteLine($"Potencia aumentada = {carro.PotenciaAumentada(potencia, out double velocidade)}\nVelocidade aumentada = {velocidade}");

Console.ReadKey();


public class Carro
{
    public double PotenciaAumentada(double potencia, out double velocidade)
    {
        potencia += 7;
        velocidade = (potencia * 1.75);

        return potencia;
    }
}