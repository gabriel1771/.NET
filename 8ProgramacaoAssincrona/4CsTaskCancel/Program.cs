using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace _4CsTaskCancel;

internal class Program
{
    private static CancellationTokenSource cancellationTokenSource;
    static async Task Main(string[] args)
    {
        var stopwatch = new Stopwatch();
        stopwatch.Start();

        try
        {
            cancellationTokenSource = new CancellationTokenSource();
            cancellationTokenSource.Cancel();

            var resultado = await OperacaoLongaDuracaoCancelavel(100,
                                  cancellationTokenSource.Token);

            Console.WriteLine(resultado);
        }
        catch (Exception)
        {

            Console.WriteLine($"Tarefa cancelada: " + $"tempo expirado após {stopwatch.Elapsed}. \n");
        }

        Console.ReadKey();
    }

    private static  Task<int> OperacaoLongaDuracaoCancelavel(int valor,
            CancellationToken cancellationToken = default)
    {
        Console.WriteLine("Executou Operação de longa duração");

        Task<int> task  = null;

        //inicia a tarefa e retorna 
        task = Task.Run(() =>
        {
            int resultado = 0;
            // Itera no laço for
            for (int i = 0; i < valor; i++)
            {

                if (cancellationToken.IsCancellationRequested)
                    throw new TaskCanceledException(task);

                //gasta o tempo 
                Thread.Sleep(50);
                resultado += 9;

            }
            return resultado;
        });
        return  task;
    }

    private static Task<int> OperacaoLongaDuracao(int valor)
    {
        Console.WriteLine("Executou Operação de longa duração");

        //inicia a tarefa e reorna 
        return Task.Run(() =>
        {
            int resultado = 0;
            // Itera no laço for
            for (int i = 0; i < valor; i++)
            {
                //gasta o tempo 
                Thread.Sleep(50);
                resultado += 9;

            }
            return resultado;
        });
    }
}
