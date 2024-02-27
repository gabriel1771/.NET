

string caminhoArquivo = @"C:\Users\reisg\OneDrive\Desktop\devBack\LinguagemC#\ArquivosDiretoriosStream\6FileStream\poesia.txt";

try
{
    ////dentro do using de pois de usar todos os recursos ele fecha automatico
    //using (FileStream fs = new(caminhoArquivo, FileMode.Open, FileAccess.Read)) 
    //{
    //    using (StreamReader leitor = new(fs))
    //    {
    //        string? linha;
    //        while ((linha = leitor.ReadLine()) != null)
    //        {
    //            Console.WriteLine(linha);
    //        }
    //    }
    //}


    /*FORMA do C#8 E POSTERIORES*/

    //dentro do using de pois de usar todos os recursos ele fecha automatico
    //DA PRA SIMPLIFICAR MAIS AINDA DAI
    //using FileStream fs = new(caminhoArquivo, FileMode.Open, FileAccess.Read);  
    using StreamReader leitor = File.OpenText(caminhoArquivo); //new(fs);

    string? linha;
    while ((linha = leitor.ReadLine()) != null)
    {
        Console.WriteLine(linha);
    }


}
catch (IOException ex)
{

    Console.WriteLine(ex.Message);
}
catch (Exception exception)
{

    Console.WriteLine(exception.Message);
}






Console.ReadKey();