
string caminhoDiretorio = @"C:\Users\reisg\OneDrive\Desktop\devBack\LinguagemC#\ArquivosDiretoriosStream\4DirectorInfo";

DirectoryInfo dirOrigem = new(caminhoDiretorio);

/*---------------------------------------------*/
//
Console.WriteLine("nome: " + dirOrigem.Name);
Console.WriteLine("caminho completo: " + dirOrigem.FullName);
Console.WriteLine("data da criação: " + dirOrigem.CreationTime);
Console.WriteLine("Ultimo acesso: " + dirOrigem.LastAccessTime);
Console.WriteLine("Ultimo Modificação: " + dirOrigem.LastWriteTime);
Console.WriteLine("atributos: " + dirOrigem.Attributes);


/*---------------------------------------------*/
//criando

DirectoryInfo novoDiretorio = new(@"C:\Users\reisg\OneDrive\Desktop\devBack\LinguagemC#\ArquivosDiretoriosStream\4DirectorInfo\meuDiretorio");

try
{
	if (!novoDiretorio.Exists)
	{
		novoDiretorio.Create();
        Console.WriteLine("diretorio criado");
    }
	else
	{
        Console.WriteLine("diretorio ja existe");
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);

}

/*---------------------------------------------*/
//deletando diretorio

try
{
    if (novoDiretorio.Exists)
    {
        novoDiretorio.Delete();
        Console.WriteLine("diretorio Deletado");
    }
    else
    {
        Console.WriteLine("diretorio não existe");
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);

}


/*---------------------------------------------*/
//subdiretorios

try
{
    foreach (DirectoryInfo item in dirOrigem.GetDirectories())
    {
        Console.WriteLine(item.Name);
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);

}

/*---------------------------------------------*/
//subarquivos

try
{
    foreach (FileInfo item in dirOrigem.GetFiles())
    {
        Console.WriteLine(item.Name);
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);

}

/*---------------------------------------------*/
//criando um subdiretorio através da instancia usada já

try
{
    dirOrigem.CreateSubdirectory("novoDiretorio");
    Console.WriteLine("subdiretorio criado");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);

}


Console.ReadKey();