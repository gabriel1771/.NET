
using _3SerializacaoJSON;
using System.Text.Json;

string caminho = @"C:\Users\reisg\OneDrive\Desktop\devBack\LinguagemC#\7Serializacao\3SerializacaoJSON\serializacao.jSON";

Aluno aluno1 = new("Maria", 101, 14, "maria@gmail.com");

using (FileStream objStreamWrite = new(caminho, FileMode.OpenOrCreate, FileAccess.ReadWrite))
{
    JsonSerializer.Serialize(objStreamWrite, aluno1);
}


Console.WriteLine("objeto serializado para json com sucesso");
Console.ReadKey();