
Console.WriteLine("Inciando processamento assincrono");
await MetodoSemRetorno();

ValueTask<int> valor =  MetodoRetornaValor(4);
Console.WriteLine("carregando");
int valor1 = await valor;
Console.WriteLine(valor1);




Console.ReadKey();

//no caso ValueTask só aloca na memoria se na hora que o cursos de processamente chegar na execução de alguma tarefa essa tarefa não ser finalizada 
//no momento que ele chegar nela, ou seja se o cursos passar pelo chamado da tarefa e a tarefa retornar instantaniamente o retorno que ela precias dar 
// então não sera alocado nada referente a tarefa,  que por sua vez se fosse pelo Task<t> iria alocar de qualquer jeito
static async ValueTask MetodoSemRetorno()
{
    Console.WriteLine("Método que retorna nada");
    await Task.Delay(2000);
}

static async ValueTask<int> MetodoRetornaValor(int valor)
{
    Console.WriteLine("Método que retorna um valor");
    await Task.Delay(4000);
    return 2 * valor;
}