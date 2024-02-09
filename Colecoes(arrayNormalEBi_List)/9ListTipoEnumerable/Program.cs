/*
#LISTA DO TIPO NUMERABLE
1° essa lista não existe, ela apenas é uma requisição de uma outra lista ou afim.
2°e sua criação é adia (só sera criada quando for requisitada uma leitura pra o mesmo) e logo de pois se desfaz
3° quando for uma lista muito grande ou/e que não precise ser acessada toda hora, então pode-se usar esse tipo se não é melhor usar do tipo padrão List que é uma 
lista que exite

#LISTA DO TIPO LIST
1° ela é um alista de verdade, que exite e fica armazenada
*/

var limiteCredito = new List<Limite>();

for (int i = 1; i< 16; i++)
{
    limiteCredito.Add(new Limite() { Numero = i }); 
}

var limitesComRestricao = limiteCredito.Where(x =>x.AnalisaLimite());



Limite objetoo = new();

foreach (Limite item in limitesComRestricao)
{
    objetoo = item;
    Console.WriteLine(item.Numero);
}

if (limitesComRestricao.Count() > 3)
{
    Console.WriteLine("\n### Temos mais de 3 limites com restrição");
   
    
}

if (limitesComRestricao.Count() > 5)
{
    Console.WriteLine("\n### Temos mais de 5 limites com restrição");
}



Console.WriteLine("\nFim do processamento...");

Console.ReadKey();

public class Limite
{
    public int Numero { get; set; }
    private bool isRestricao;
    
    public Limite()
    {
        var semente = Guid.NewGuid().GetHashCode();
        var numeroAleatorio = new Random(semente).Next(1, 4);
        isRestricao = numeroAleatorio == 1;
    }

    public bool AnalisaLimite()
    {
        Console.WriteLine($"Executa análise de limite de Crédito para limite {Numero}");
        return isRestricao;
    }
}
