namespace _9Semaforos_GerenciaThreads_
{
    internal class Program
    {
        //primeiro se intancia a classe semaphore e se define no construtor 
        //quantos threads vão ser executados de inicio e quantos no total 
        public static Semaphore threadPool = new(3, 5);



        static void Main(string[] args)
        {

            for (int i = 0; i < 10; i++)
            {

                Thread threadObject = new(new ThreadStart(ProcessarOperacao));

                threadObject.Name = "Thread : " + i;
                threadObject.Start();
            }


            Console.ReadKey();


            static void ProcessarOperacao()
            {
                //aqui no caso, quando o compilador entrar aqui ele vai incrementar o numero de threads que está sendo excutado 
                //e vai seguindo executando o que tem nas proximas linhas.
                //só que enquanto isso estiver acontecendo o compilador vai voltar para o chamador do metodo e seguir pras proximas linhas 
                //que é o que aconteces nas tasks 

                //entendido isso temos que notar tambem que nas proximas linhas do compilador ele vai seguir criando novas threads(execução do meu metodo de forma assincrona)
                // fazer isso 10 vezes, porem temos um semaforo que vai permitir apenas 3 threads ao mesmo tempo

                //de pois que o codigo dentro do metodo que está sendo processado de forma assincrona acabar de ser processado ele chega na linha onde vai chamar 
                //o metodo release() que vai liberar pra mais um metodo entrar em processamento ou seja vai decremetar o numero de threads sendo processadas e automaticamente
                //se tiver threads esperando para ser processadas, essas mesmas vão inciar

                //e isso vai acontecer até todas as threads serem processadas

                //so mais uma obsercação: de inicio iram ser processadas 3 threads, porem logo de pois que a primeira for liberada
                //o numero de threads a ser processada sobre pra 5 isso respeita os parametros definidos la em cima na instancia do objeto

                threadPool.WaitOne();
                Console.WriteLine($"Thread {Thread.CurrentThread.Name} " +
                    $"entrou na sessão critica ...");

                Thread.Sleep(6000);

                threadPool.Release();
                Console.WriteLine($"Thread {Thread.CurrentThread.Name} " +
                    $"foi liberada");
            }


        }
    }
}
