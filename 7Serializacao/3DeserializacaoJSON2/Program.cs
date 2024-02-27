
using System.Text.Json;
using _3DeserializacaoJSON2;

string caminho = @"C:\Users\reisg\OneDrive\Desktop\devBack\LinguagemC#\7Serializacao\3DeserializacaoJSON2\serializacao.jSON";

//Lê todo conteudo e retorna uma string
string textoJson = File.ReadAllText(caminho);

var aluno = JsonSerializer.Deserialize<Aluno>(textoJson);

Console.WriteLine(aluno.Nome + " " + aluno.Idade );


Console.ReadKey();