
using System.Runtime.CompilerServices;

/*---------------------------------------------*/
//agr um metodo ASSINCRONO que retorna uma tarafa que retorna um IENUMERABLE<T>

internal class Program
{
     static async Task Main(string[] args)
    {


        //var meses = new List<string>() { "janeiro", "fevereiro", "março", "abriel" };

        //aqui eu estou não apenas iterando e criando um IEnumerable
        //porem estou fazendo isso agr, de uma forma assincrona
         await foreach (var item in Gerameses())
        {
            Console.WriteLine(item);
        }

        

        Console.ReadKey();


        
    }

    static private async IAsyncEnumerable<string> Gerameses()
    {
        yield return "janeiro";
        yield return "fevereiro";
        await Task.Delay(2000);
        yield return "março";
        yield return "abril";
    }
}


/*---------------------------------------------*/
//um metodo(iterador) que retorna um IEnumerable

//internal class Program
//{
//    private static void Main(string[] args)
//    {


//        //var meses = new List<string>() { "janeiro", "fevereiro", "março", "abriel" };

//        foreach (var item in Gerameses())
//        {
//            Console.WriteLine(item);
//        }

//        Console.ReadKey();


//    }

//    static private IEnumerable<string> Gerameses()
//    {
//        yield return "janeiro";
//        yield return "fevereiro";
//        yield return "março";
//        yield return "abril";
//    }
//}