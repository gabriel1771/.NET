
try
{
    string caminhoOrigem = @"C:\Users\reisg\OneDrive\Desktop\devBack\LinguagemC#\ArquivosDiretoriosStream\1ArquivoDiretorios\arquivo1.txt";

    //criando arquivo e verificando se existe
    if (File.Exists(caminhoOrigem))
    {
        Console.WriteLine("Ja existe não precisa escrever novamente");
    }
    else
    {
        //o metodo Create parece que abre uma instancia ou processo que precisa ser fechado se eu quiser trabalhar com esse arquivo fora
        //dessa instancia ou metodo, por isso precisa fechar ou teriminar com esse processo pra seguir
        //using (FileStream fs = File.Create(caminhoOrigem)) ;
        File.Create(caminhoOrigem).Close();
        
    }


    /*---------------------------------------------*/
    //escrevendo no arquivo
    File.WriteAllText(caminhoOrigem, "Fernando Pessoa");


    /*---------------------------------------------*/
    //adcionando outros textos
    string novoTexto = "o poeta é um fingidor" + Environment.NewLine +
                        "Finge tão completamente\n" +
                        "que nem sente";

    File.AppendAllText(caminhoOrigem, novoTexto);


    /*---------------------------------------------*/
    //lendo o arquivo

    string texto = File.ReadAllText(caminhoOrigem);

    Console.WriteLine(texto);

    /*---------------------------------------------*/
    //ultima modificação

    DateTime ultimaModificacao = File.GetLastWriteTime(caminhoOrigem);
    Console.WriteLine();
    Console.WriteLine(ultimaModificacao);

    /*---------------------------------------------*/
    //ultimo acesso feito

    Console.WriteLine(File.GetLastAccessTime(caminhoOrigem));

    /*---------------------------------------------*/
    //array de strinh onde cada linha é uma item no array

    string[] linhas = File.ReadAllLines(caminhoOrigem);

    foreach (string item in linhas)
    {
        Console.WriteLine(item);
    }

    /*---------------------------------------------*/
    //caminho copia

    string caminhoCopia = @"C:\Users\reisg\OneDrive\Desktop\devBack\LinguagemC#\ArquivosDiretoriosStream\1ArquivoDiretorios\arquivoCopia.txt";

    File.Copy(caminhoOrigem, caminhoCopia, true);  //esse tru é para sobeescrever

    /*---------------------------------------------*/
    //movendo arquivo

    string caminhoDestino = @"C:\Users\reisg\OneDrive\Desktop\devBack\LinguagemC#\ArquivosDiretoriosStream\1ArquivoDiretorios\arquivosCopiados\arquivo1.txt";

    File.Move(caminhoCopia, caminhoDestino, true);

    /*---------------------------------------------*/
    //deletando

    File.Delete(caminhoDestino);
    File.Delete(caminhoOrigem);
    //File.Delete(caminhoCopia);
}
catch (Exception ex)
{

    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.StackTrace);
}



Console.ReadKey();