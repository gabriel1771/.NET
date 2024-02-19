Console.WriteLine("##EXERCICIOS DE FIXAÇÃO##");

string[] nomes = new string[5];
double[] notas = new double[5];

for (int i = 0; i < nomes.Length; i++)
{
    Console.WriteLine("Digite o nome e a notas: ");
    nomes[i] = Console.ReadLine();
    notas[i] = Convert.ToDouble(Console.ReadLine());

}

foreach(string item in nomes)
{
    Console.WriteLine(item);
}

foreach (var item in notas)
{
    Console.WriteLine(item);
}

double soma = 0.0;

foreach( double item in notas)
{
    soma += item;
}

double media = (soma / notas.Count());

Console.WriteLine("\n\n media: " + media);


Console.ReadKey();