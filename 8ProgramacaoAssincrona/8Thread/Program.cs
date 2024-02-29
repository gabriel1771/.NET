/*                                     THREAD
 É uma classe que te permite transformar um metodo que você criou, em um metodo assincrono
 ou seja, voce passa como parametro dessa classe o chamador do seu metodo, e então esse metodo vai
 ter seu processamento de uma forma assincron, coisa que conseguimos alcançar usando os metodos assincronos
 task, taks<t>, valueTask e valueTask<t>, porem usando a classe Tread é um facilitador, no entando 
 ao usar a classe tread pode ser mais dificil seu gerenciamento, podendo acarretar em um alto custo de desempenho 
 tornando assim os metodos asyn/await mais eficiente e faceis de gerenciar e desenvolver

*/

//exemplo do uso da classe Thread


for (int i = 0; i< 10; i++)
{
    //aqui estou instanciando a classe Thread
    //e no caso eu não possso passar um metodo como parametro, somente um 
    //delegate por isso é passado assim mas atualmente ja é suportado
    //passar direto o metodo
    Thread threadObject = new(new ThreadStart(ProcessarOperacao));

    threadObject.Name = "Thread : " + i;
    threadObject.Start();
}

Console.ReadKey();


//metodo comum
 static void ProcessarOperacao()
{
    Console.WriteLine($"Thread {Thread.CurrentThread.Name} " + 
        $"entrou na sessão critica ...");

    Thread.Sleep(6000);

    Console.WriteLine($"Thread {Thread.CurrentThread.Name} " +
        $"foi liberada");
}