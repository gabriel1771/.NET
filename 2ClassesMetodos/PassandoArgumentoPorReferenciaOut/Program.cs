Console.WriteLine("##PASSAGEM POR REFERENCIA - OUT##");
//PRINCIPAL DIFERENÇA = da pra declarar a variavel no parametro mesmo, não precisa estar declarada já como o ref

Console.WriteLine("Informe o raio do círculo");
double raio = Convert.ToDouble(Console.ReadLine());

Circulo circulo = new Circulo();

double perimetro = circulo.CalculaPerimetro(raio, out double area);

Console.WriteLine("Perímetro da Circunferencia" + perimetro);
Console.WriteLine("Área  da Circunferencia" + area);

Console.ReadKey();

public class Circulo
{

    public double CalculaPerimetro(double raio, out double area)
    {
        area = Math.PI * Math.Pow(raio, 2);
        double perimetro = 2 * Math.PI * raio;
        return perimetro;
    }
}