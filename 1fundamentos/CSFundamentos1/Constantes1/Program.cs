Console.WriteLine("##CONSTANTES##\n");

/*---------------------------------------------------*/
//definindo constantes

const int ANO = 12;
const int MES = 30, QUINZENA = 15, SEMANA = 7;
const int MESES_ANOS = 12;
const int DIAS_ANOS = 365;

const float DIAS_POR_MES = (float)DIAS_ANOS / (float) MESES_ANOS;

Console.WriteLine(DIAS_POR_MES);
Console.WriteLine();

/*---------------------------------------------------*/
//calculo para calcular o perimetro e área do circulo

double perimetro, area, raio;
const double PI = 3.14;

Console.WriteLine("Digite o valor do raio");

raio = Convert.ToDouble(Console.ReadLine());

perimetro = 2 * raio * Math.PI;
area = Math.Pow(raio, 2) * Math.PI;

Console.WriteLine($"perimetro do circulo é: {area}");
Console.WriteLine($"area do circulo é: {perimetro}");

Console.ReadKey();