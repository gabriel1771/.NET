using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace _4CsTaskCancel_depois_de_um_certo_tempo_;

/*---------------------------------------------*/

internal class Program
{
    //private static CancellationTokenSource cancellationTokenSource;
    static async Task Main(string[] args)
    {
        var stopwatch = new Stopwatch();
        stopwatch.Start();

        try
        {
            //cancellationTokenSource = new CancellationTokenSource();
            //cancellationTokenSource.Cancel();

            //var resultado = await OperacaoLongaDuracaoCancelavel(100,
            //                      cancellationTokenSource.Token);


            //Console.WriteLine("Cancelamento automatico após 1,5 segundos");
            // //await ExecutaCancelamentoComTimeout(2500);
            // await ExecutaCancelamentoComTimeoutCancelAfter(3000);

            //Console.WriteLine(resultado);


            Console.WriteLine("Cancelamento Manual");
            await ExecutaCancelamentoManual();
        }
        catch (Exception)
        {

            Console.WriteLine($"Tarefa cancelada: " + $"tempo expirado após {stopwatch.Elapsed}. \n");
        }

        Console.ReadKey();
    }

    /*---------------------------------------------*/
    //metodo que ao ser chamado dispões da funcionalidade de cancelamento manual(ele cria uma tarefa que vai esperar qualquer tecla do teclado
    //de pois de iniciar o processamento dessa tarefa o compilado segue para as proximas linhas e então acaba entrando no try onde 
    //é chamadoa funcão que demora que possui o parametro de cancelamento(token) porem se não for cancelado ele fica aguardando acabar o 
    //processamento da função demorada
    public static async Task ExecutaCancelamentoManual()
    {
        using (var cancellationTokenSource = new CancellationTokenSource())
        {
            var TecladoTask = Task.Run(() =>
            {
                Console.WriteLine("Pressione algo para Cancelar ou espere terminar o processamento");
                Console.ReadKey();
                cancellationTokenSource.Cancel();
            });
            try
            {
                var tarefa = OperacaoLongaDuracaoCancelavel(100, cancellationTokenSource.Token);
                var resultado = await tarefa;
                Console.WriteLine($"tarefa finalmente acabou Resultado {resultado}");
            }
            catch (TaskCanceledException)
            {
                throw;
            }
            await TecladoTask;
        }
    }

    /*---------------------------------------------*/
    //metodo que usa o metodo CancelAfter pra definir quanto tempo passa até cancelar a tarefa
    public static async Task ExecutaCancelamentoComTimeoutCancelAfter(int tempo)
    {
        using (CancellationTokenSource cancellationTokenSource = new())
        {
            cancellationTokenSource.CancelAfter(tempo);
            try
            {
                var resultado = await OperacaoLongaDuracaoCancelavel(100,
                    cancellationTokenSource.Token);
                Console.WriteLine($"Resultado {resultado}");
            }
            catch (TaskCanceledException)
            {

                throw;
            }
        }
    }

    /*---------------------------------------------*/
    //metodo que usa o contrutor da classe CancellationTokenSource estanciado no objeto, com um parametro de tempo para cancelar a tarefa
    //de pois que esse tempo exceder
    public static async Task ExecutaCancelamentoComTimeout(int tempo)
    {
        using (CancellationTokenSource cancellationTokenSource = new(tempo))
        {
            try
            {
                var resultado = await OperacaoLongaDuracaoCancelavel(100,
                    cancellationTokenSource.Token);
                Console.WriteLine($"Resultado {resultado}");
            }
            catch (TaskCanceledException)
            {

                throw;
            }
        }
    }

    /*---------------------------------------------*/
    //metodo assincrono(tarefa) que vai cancelar se por algum acaso seu parametro de token de cancelamento estiver ativado
    // e isso pode ser feito ativando ele externamente usando o metodo cancel() que pode ser usado por exemplo quando for clicado em 
    //um botão...
    private static  Task<int> OperacaoLongaDuracaoCancelavel(int valor,
            CancellationToken cancellationToken = default)
    {
        Console.WriteLine("Executou Operação de longa duração");

        Task<int> task = null;

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
                resultado += i;

            }
            return resultado;
        });
        return task;
    }

    /*---------------------------------------------*/
    //metodo assincrono

    public static Task<int> OperacaoLongaDuracao(int valor)
    {
        Console.WriteLine("Executou Operação de longa duração");

        //inicia a tarefa e reorna 
        return   Task.Run(() =>
        {
            int resultado = 0;
            // Itera no laço for
            for (int i = 0; i < valor; i++)
            {
                //gasta o tempo 
                Thread.Sleep(50);
                resultado += i;

            }
            return resultado;
        });
    }
}
