using System.Threading;

namespace _10SemaphoresSlim;

internal class Program
{
    //primeiro se intancia a classe semaphore e se define no construtor 
    //quantos threads vão ser executados ao mesmo tempo
    private static SemaphoreSlim SemaforoSlim = new(4);



    static void Main(string[] args)
    {

        for (int i = 0; i <= 6; i++)
        {

            string threadName = "Theread" + i;
            int espera = 2 + 2 * i;

            var t = new Thread(() => 
                AcessarBancoDados(threadName, espera));

            t.Start();
        }

    }

        private static void AcessarBancoDados(string nome, int seconds)
        {

        Console.WriteLine($"{nome} aguardar para acessar o banco de dados...");
        SemaforoSlim.Wait();

        Console.WriteLine($"{nome} foi autorizada a acessar o banco de dados");
        Thread.Sleep(10000/*TimeSpan.FromSeconds(seconds)*/);

        Console.WriteLine($"{nome} foi concluida...");
        SemaforoSlim.Release();
    }
}
