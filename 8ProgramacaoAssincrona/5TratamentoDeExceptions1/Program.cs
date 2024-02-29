/*---------------------------------------------*/
//TesteAsync t = new();
//t.ChamaTarefaAsync();

/*---------------------------------------------*/
await LancaExceptionAsync();


Console.ReadKey();

/*---------------------------------------------*/
//exemplo 2 de como tratar um excption em um codigo assincrono
static async Task LancaExceptionAsync()
{
    try
    {
        //essa task vai conter o um excption que pode ser asseçada de pois
        var primeiraTask = Task.Run(() =>
        {
            Task.Delay(1000);
            throw new IndexOutOfRangeException
            ("IndexOutOfException lançada explicitamente.");
        });

        await primeiraTask;
    }
    catch (Exception ex)
    {
        Console.Write(ex.Message);
    }
}



/*---------------------------------------------*/
//exemplo 1 de como tratar um excption em um codigo assincrono

class TesteAsync
{
    public Task MinhaTarefaAsync()
    {
        //aqui eu crio uma tarefa e a mesma ao iniciar seu processamento 
        //vai ser retornada 
        return Task.Run(() =>
        {
            Task.Delay(2000);
            throw new Exception("Minha Exception...");
        });
    }

    public async void ChamaTarefaAsync()
    {
        //aqui que se trata a excption de um processamento assincrono
        try
        {

            await MinhaTarefaAsync();
        }
        catch (Exception ex)
        {

            Console.WriteLine(ex.Message);
        }
    }
}



