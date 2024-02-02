namespace CarroEnum;

public enum Cores
{
    Branco = 1, 
    Vermelho, 
    Preto, 
    Cinza, 
    Prata, 
    Azul
}

public class Carro
{
    public int Cor;


    public Carro(int cor)
    {
        Cor = cor;
    }

    public void ExibirInfo()
    {
        Console.WriteLine((Cores)Cor);
    }

}