using _2DeserializacaoXML;
using System.Xml.Serialization;

string caminho = @"C:\Users\reisg\OneDrive\Desktop\devBack\LinguagemC#\7Serializacao\2DeserializacaoXML\serializacao.xml";

XmlSerializer objSerializer = new(typeof(Aluno));

using (StreamReader objStreamReader = new(caminho))
{
    var objAlunoDeserializado = (Aluno)objSerializer.Deserialize(objStreamReader);
    Console.WriteLine(objAlunoDeserializado.Nome + " " + objAlunoDeserializado.E);
}


    Console.ReadKey();