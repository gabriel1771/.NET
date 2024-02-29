/*
 * O QUE É UM METODO ITERADOR? 
 *      É UM METODO QUE POSSUI VARIOS RETURNS DE UMA VEZ SÓ OU SEJA(ELE ITERA VALORES INDIVIUAIS) QUE SE FOR JUNTAR TODOS ESSES
 *      VALORES FORMAM UMA COLEÇÃO IENUMERABLE E PAR TRANSFORMAR EM UMA COLEÇÃO DO TIPO LIST É SO ADICIONAR O METODO ,TOlIST();
 *
#LISTA DO TIPO IENUMERABLE
1° essa lista não existe, ela apenas é uma requisição ou processamento de uma outra lista ou METODO ITERADOR que juntando todos os retornos
formam uma lista que precisa usar um loop para acessar seus itens.
2°e sua criação é adiada (só sera criada quando for requisitada uma leitura pra o mesmo (loop)) e logo de pois se desfaz
3° quando for uma lista muito grande ou/e que não precise ser acessada toda hora, então pode-se usar esse tipo se não é melhor usar do tipo
padrão List que é uma lista que exite

#LISTA DO TIPO LIST
1° ela é um alista de verdade, que exite e fica armazenada
*/



/*
 UM EXEMPLO É ISSO: 

private static void Main(string[] args)
    {


        //var meses = new List<string>() { "janeiro", "fevereiro", "março", "abriel" };

        foreach (var item in Gerameses())
        {
            Console.WriteLine(item);
        }

        Console.ReadKey();

        
    }

    static private IEnumerable<string> Gerameses()
    {
        yield return "janeiro";
        yield return "fevereiro";
        yield return "março";
        yield return "abril";
    }
 
 
 */


//OUTRO EXEMPLO É ESSE:

var limiteCredito = new List<Limite>();

for (int i = 1; i< 16; i++)
{
    limiteCredito.Add(new Limite() { Numero = i }); 
}


/*var*/IEnumerable<Limite> limitesComRestricao = limiteCredito.Where(x =>x.AnalisaLimite());



Limite objetoo = new();

foreach (var item in limitesComRestricao)
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
