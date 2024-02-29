
//await LancaMultiplasExcecoesAsync1();

await LancaMultiplasExcecoesAsync2();


Console.ReadKey();

/*---------------------------------------------*/
//forma certa de se ter um metodo onde se chama varias tarefas e se 
//trata as possiveis exceptions causadas por elas

static async Task LancaMultiplasExcecoesAsync2()
{
	Task? tarefas = null;
	try
	{
		var primeiraTask = Task.Run(() =>
		{
			Task.Delay(1000);
			throw new IndexOutOfRangeException
			("IndexOutOfRangeException lançada explicitamente.");
		});
        var segundaTask = Task.Run(() =>
        {
            Task.Delay(1000);
            throw new InvalidOperationException
            ("InvalidOperationException lançada explicitamente.");
        });

        //aqui ele aguarda as duas tarefas terminarem
        //e quando todas estiverem termidas ele coloca todas 
        //em uma unica tarefa
        tarefas = Task.WhenAll(primeiraTask, segundaTask);
        await tarefas;

    }
	catch
	{
		Console.WriteLine("Ocorreram as seguintes exceções");

		//aqui eu cria uma variavel onde possui todas as exceptions 
		//de todas as tarefas contidas na variavel tarefas
		AggregateException TodasExceptions = tarefas.Exception;

		foreach (var ex in TodasExceptions.InnerExceptions)
		{
			Console.WriteLine(ex.GetType().ToString() + "    " + ex.Message);
		}
	}
}



/*---------------------------------------------*/
//forma errada e que não funciona de se ter um metodo onde é chamado varias tarefas
//e onde se trata todas as exceções que as mesmas podem estourar
static async Task LancaMultiplasExcecoesAsync1()
{
	Task? tarefas = null;

    try
	{
		var primeiraTask = Task.Run(() =>
		{
			Task.Delay(1000);
			throw new IndexOutOfRangeException
			("IndexOutRangeException lançada explicitamente.");
		});
		var segundaTask = Task.Run(() =>
		{
			Task.Delay(1000);
			throw new InvalidOperationException
			("InvalidOperationException lançada explicitamente");

		});
		//aqui ele aguarda as duas tarefas terminarem
		//e quando todas estiverem termidas ele coloca todas 
		//em uma unica tarefa, neste caso não estou tratando 
		//corretamente as exceptions, pois mesmo eu tendo 
		//uma tarefa com todas as tarefas concluidas e suas possiveis
		//exceptions, eu não estou usando disso, e estou tratando 
		//a primeira que estourar
		tarefas =  Task.WhenAll(primeiraTask, segundaTask);
		await tarefas;
	}
	catch (IndexOutOfRangeException ex)
	{
		Console.WriteLine(ex.Message);	
	}
	catch (InvalidOperationException ex)
	{
		Console.WriteLine(ex.Message);
	}
}