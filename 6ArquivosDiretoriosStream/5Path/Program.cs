

string caminhoDiretorio = "C:\\Users\\reisg\\OneDrive\\Desktop\\devBack\\LinguagemC#\\ArquivosDiretoriosStream\\5Path";

char separador = Path.DirectorySeparatorChar;
Console.WriteLine("O separador padrão para windos é: " + separador);

string[] diretorios = caminhoDiretorio.Split(separador);
Console.WriteLine("os diretorios e caminhos são: ");
foreach (string item in diretorios)
{
    Console.WriteLine(item);
}

/*---------------------------------------------*/
//caminho absoluto
string path1 = "C:\\Users\\reisg\\OneDrive\\Desktop\\devBack\\LinguagemC#\\ArquivosDiretoriosStream\\5Path";

//caminho relativo
string path2 = "5Path\\poesia.txt";

//combinando os caminhos

string caminhoCombinado = Path.Combine(path1, path2);
Console.WriteLine("path combinado: " + caminhoCombinado);

//metodos mais usados
Console.WriteLine("nome do diretorio: " + Path.GetDirectoryName(caminhoCombinado));
Console.WriteLine("extensão: " + Path.GetExtension(caminhoCombinado));
Console.WriteLine("nome do diretorio: " + Path.GetDirectoryName(caminhoCombinado));
Console.WriteLine("nome do arquivo: " + Path.GetFileName(caminhoCombinado));
Console.WriteLine("sem extensão: " + Path.GetFileNameWithoutExtension(caminhoCombinado));
Console.WriteLine("Possui extensão?" + Path.HasExtension(caminhoCombinado));
Console.WriteLine("tem a raiz? " + Path.IsPathRooted(caminhoCombinado));
Console.WriteLine("raiz: " + Path.GetPathRoot(caminhoCombinado));

//sem usar o path combinado
Console.WriteLine("nome do arquivo aleatório: " + Path.GetRandomFileName());
Console.WriteLine("nome do arquivo temporario: " + Path.GetTempFileName());
Console.WriteLine("nome do caminho temporario: " + Path.GetTempPath());


//caracter invalido
char[] arrayDeCaracterInvalidos = Path.GetInvalidFileNameChars();
Console.WriteLine("caracteres invalidos em nomes de arquivos: " + new string(arrayDeCaracterInvalidos) );


Console.ReadKey();
