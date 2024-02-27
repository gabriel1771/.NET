
/*AO LER OU ESCREVER É BOM USAR O BLOCO TRYCATCH PARA PODER TER CERTEZA QUE VAI SER FECHADO O RECURSO COMPUTACIONAL*/


string caminhoArquivo = "C:\\Users\\reisg\\OneDrive\\Desktop\\devBack\\LinguagemC#\\ArquivosDiretoriosStream\\6FileStream\\poesia.txt";

//FileStream fs = null;
StreamReader leitor = null;

try
{
	//criando 
	//fs = new FileStream(caminhoArquivo, FileMode.Open, FileAccess.Read);
	leitor = File.OpenText(caminhoArquivo); /*com isso não precisa declarar o fileStream*/    //new StreamReader(fs);

	//lendo

	string linha; 

	while ((linha = leitor.ReadLine()) != null)
	{
        Console.WriteLine(linha);
    }
}
catch (IOException eo)
{
    Console.WriteLine(eo.Message);
}
catch (Exception ex)
{

    Console.WriteLine(ex.Message);
}
finally
{
	// AQUI EU VOU GARANTIR QUE VAI SER FECHADO O RECURSO COMPUTACIONAL CONECTADO AO SISTEMA E A MEMORIA
	if (leitor != null) leitor.Close();
	//if (fs != null) fs.Close();
}


Console.ReadKey();