using System.Runtime.ConstrainedExecution;

await ExecutaOperacaoAsync();

Console.ReadKey();

static async Task ExecutaOperacaoAsync()
{
    var tempo = 1;

    //criar um CancellationTokenSource
    //cira o objeto onde vai ter o token de cancelamento...
    var cancellationTokenSource = new CancellationTokenSource(TimeSpan.FromSeconds(tempo));

    Console.WriteLine("\nIniciando download...");
    Console.WriteLine($"\nCancelando a operação após {tempo} segundos...");

    try
    {
        //cria o objeto para se comunicar e executar coisas no servidor
        using var httpClient = new HttpClient();
        var destino = @"C:\Users\reisg\OneDrive\Desktop\devBack\LinguagemC#\8ProgramacaoAssincrona\6ExercicioEnvolvendoTudoAtéAgr\poesia1.txt";

        //cria variavel que vai possuir a resposta onde vai ter varios dados sobre a requisição essa resposta nada mais é do que 
        //a resposta do aguardo(await) de uma tarefa criada pelo metodo da classe HttpClient com os parametros descritos
        var response = await httpClient.GetAsync("https://www.macoratti.net/dados/Poesia.txt", HttpCompletionOption.ResponseHeadersRead, cancellationTokenSource.Token);

        //com a variavel de cima consigo o tamanho em bytes que sera o pacote da requisição
        var totalBytes = response.Content.Headers.ContentLength;
        var readBytes = 0L; //numero do tipo long

        //crio um objeto(processamento) fileStream para escrever o conteudo da requisição
        //que no caso agr vai experar essa criação ser feita usando o await e logo de pois já vai fechar o fileStream com o using
        await using var fileStream = new FileStream(destino, FileMode.Create,
                                                             FileAccess.Write);

        //1.crio uma variavel do tipo STREAM(variavel onde possui um conteudo binario) que vai aguardar receber o conteudo que ela está
        //sendo atribuido e logo de pois vai fechar esse Stream
        //2.o conteudo que ele espera receber vai vir de uma tarefa criada apartir do objeto response onde possui dados da requisição
        //essa tarefa novamente vai ser aguardada sua finalização pelo compilador para se obter o retorno(stream) 
        //3.lembrando que essa tarefa pode ser cancelada pelo token destacada no parametro
        await using var /*Stream*/ contentStream = await response.Content.ReadAsStreamAsync(cancellationTokenSource.Token);

        //aqui eu estou criando um array de bytes(que vai possuir o conteudo(stream), estou reservando o tamanho dele já 
        //lembrando que vai ter 81920 elementos nesse array, e cada elemento nesse array vai ser um byte de tamanho
        var buffer = new byte[81920];

        //e aqui estou criando uma variavel int 
        int bytesRead;

        //aqui nos temos duas tarefas acontecendo a cada repetição, onde a primeira acontece na condição do while
        //essa tarefa aramazena parte do stream(conteudo em bytes retornado da requisição) em uma variavel do tipo byte 
        // e então retorna quanto foi lido e armazenado nessa variavel em forma de int e se não foi lido mais nada na stream e gravado no buffer
        // ela retorna zero para variavel int, que no caso significa que ja foi lido tudo do stream

        //logo de pois dentro do while é gravado o conteudo do buffer no fileStream aberto e adicionado o numero de bytes lidos na ultima tarefa 
        //a uma varivavel que contem o total lido nesse processo, e então se repete tudo de novo até sair do while
        while ((bytesRead = await contentStream.ReadAsync(buffer, 0, buffer.Length,
            cancellationTokenSource.Token)) > 0)
        {
            await fileStream.WriteAsync(buffer, 0, bytesRead, cancellationTokenSource.Token);
            readBytes += bytesRead;
            Console.WriteLine($"Progresso: {readBytes}/{totalBytes}");
        }
    }
    //
    catch (OperationCanceledException ex)
    {
        if (cancellationTokenSource.IsCancellationRequested)
        {
            Console.WriteLine("\nDownload cancelado por tempo limite : " + ex.Message);
        }
        else
        {
            Console.WriteLine("\nO tempo limite para o download foi atingido.");
        }
    }
    catch (HttpRequestException ex)
    {
        Console.WriteLine($"\nOcorreu um erro de rede: {ex.Message}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"\nOcorreu um erro desconhecido: {ex.Message}");
    }
    finally
    {
        Console.WriteLine("\nDownload finalizado.");
    }
}
