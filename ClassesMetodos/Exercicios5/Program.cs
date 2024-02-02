Console.WriteLine("##EXERCICIOS - 05");

Veiculo carro = new();

carro.ExibirInfo(modelo: "ret", marca: "cruce", montadora: "chevolet", potencia: 154);

Console.ReadKey();

public class Veiculo
{
    public void ExibirInfo(string modelo, string montadora, string marca, int potencia, int ano = 9999)
    {
        Console.WriteLine($"modelo: {modelo}\nmontadora: {montadora}\nmarca: {potencia}cv\nano: {ano}");
    }
}