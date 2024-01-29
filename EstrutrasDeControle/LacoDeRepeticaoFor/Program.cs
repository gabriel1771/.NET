Console.WriteLine("##LAÇO FOR##");

/*---------------------------------------------------------*/
//usando o laço for para fazer uma tabuada dinamica

int i = 0, numero, resultado;

Console.WriteLine("Digite o numero desejado para a formulação da tabuadaj, maior que zero");
numero = Convert.ToInt32(Console.ReadLine());

if (numero > 0)
{

    for (i = 1; i <= 10; i++)
    {
        resultado = numero * i;
        Console.WriteLine(numero + "X" + i + " = " + resultado);
    }
}
else
{
    Console.WriteLine("numero invalido");
}