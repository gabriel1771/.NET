
using System.ComponentModel;

string caminhoDiretorio = @"C:\Users\reisg\OneDrive\Desktop\devBack\LinguagemC#\ArquivosDiretoriosStream\3Director\MeuDiretorio\Teste";
string caminhoMovido = @"C:\Users\reisg\OneDrive\Desktop\devBack\LinguagemC#\ArquivosDiretoriosStream\3Director\NovoTeste";
string caminho = @"C:\Users\reisg\OneDrive\Desktop\devBack\LinguagemC#\ArquivosDiretoriosStream\3Director\";



try
{

    /*---------------------------------------------*/
    ////criando um diretorio 
    //if (!Directory.Exists(caminhoDiretorio))
    //{
    //    Directory.CreateDirectory(caminhoDiretorio);
    //}
    //else
    //{
    //    Console.WriteLine("esse diretorio já existe");
    //}


    /*---------------------------------------------*/
    ////excluindo um diretorio

    //if (Directory.Exists(caminhoDiretorio))
    //{
    //    Directory.Delete(caminhoDiretorio);
    //}
    //else
    //{
    //    Console.WriteLine("esse diretorio ja foi deletado antes");
    //}

    /*---------------------------------------------*/
    ////obtendo um array com os subdiretorios
    //if (Directory.Exists(caminho))
    //{
    //    string[] subdiretorios = Directory.GetDirectories(caminho, "o*");
    //    foreach( string item in subdiretorios)
    //    {
    //        Console.WriteLine(item);
    //    }
    //}
    //else
    //{
    //    Console.WriteLine("Diretorio" + caminho + "não existe");
    //}

    /*---------------------------------------------*/
    ////obtendo um array com os arquivos agr
    //if (Directory.Exists(caminho))
    //{
    //    string[] arquivos = Directory.GetFiles(caminho);
    //    foreach (string item in arquivos)
    //    {
    //        Console.WriteLine(item);
    //    }
    //}
    //else
    //{
    //    Console.WriteLine("Diretorio" + caminho + "não existe");
    //}

    /*---------------------------------------------*/
    //obtendo um array com os subdiretorios
    if (Directory.Exists(caminhoDiretorio))
    {
        Directory.Move(caminhoDiretorio, caminhoMovido);
    }
    else
    {
        Console.WriteLine("Diretorio" + caminho + "não existe");
    }





}
catch (Exception ex)
{

    Console.WriteLine(ex.Message);
}
Console.ReadKey();