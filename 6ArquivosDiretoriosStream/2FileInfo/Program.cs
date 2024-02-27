


string caminhoOrigem = @"C:\Users\reisg\OneDrive\Desktop\devBack\LinguagemC#\ArquivosDiretoriosStream\2FileInfo\poesia.txt";
string caminhoDestino = @"C:\Users\reisg\OneDrive\Desktop\devBack\LinguagemC#\ArquivosDiretoriosStream\2FileInfo\txt\poesia.txt";
string caminhoCopia = @"C:\Users\reisg\OneDrive\Desktop\devBack\LinguagemC#\ArquivosDiretoriosStream\2FileInfo\poesiaCopia.txt";

FileInfo arquivoOrigem = new(caminhoOrigem);

//nome do arquivo
Console.WriteLine($"Nome do arquivo: {arquivoOrigem.Name}");

//caminho completo
Console.WriteLine($"Caminho do arquivo: {arquivoOrigem.FullName}");

//verificando se é somente leitura
Console.WriteLine($"é somente leitura? {arquivoOrigem.IsReadOnly}");

//diretorio pai 
var diretorioPai = arquivoOrigem.Directory; //é do tipo DirectorInfo
Console.WriteLine($"diretorio superior: {diretorioPai.Name}");

//tamanho do arquivo
Console.WriteLine($"tamanho do arquivo: {arquivoOrigem.Length}");

//ultima gravação 
Console.WriteLine($"ultima gravação: {arquivoOrigem.LastWriteTime}");

//copiando arquivo
if (arquivoOrigem.Exists)
{
    arquivoOrigem.CopyTo(caminhoCopia);
}
else
{
    Console.WriteLine("arquivo não existe");
}

//movendo

arquivoOrigem.MoveTo(caminhoDestino);


Console.ReadKey();