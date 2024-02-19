Console.WriteLine("##EXERCICIOS - 3##");

/*---------------------------------------------------------------*/
//I)

int potencia = 2;

Carro automovel = new Carro();

Console.WriteLine(automovel.AumentaPotencia(2));

automovel.AumentaPotencia(ref potencia);
Console.WriteLine(potencia);


Console.ReadKey();

public class Carro
{
    public int AumentaPotencia(int potencia)
    {
        return potencia += 3;
    }


    //tinha que ser uma sobrecarga de metodo porem achei mas legal assim
    public /*int*/void AumentaPotencia(ref int variavel1)
    {
        variavel1 += 5;
    }

} 

 
