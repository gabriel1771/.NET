using _2SerializacaoXML;
using System.Xml.Serialization;


string caminho = @"C:\Users\reisg\OneDrive\Desktop\devBack\LinguagemC#\7Serializacao\SerializacaoXML\serializacao.xml";

Aluno aluno = new("Maria", 2, 20, "maria@gmail.com");

XmlSerializer objSerializer = new(typeof(Aluno));

using (StreamWriter objStreamWrite = new(caminho))
{
    objSerializer.Serialize(objStreamWrite, aluno);
}

Console.WriteLine("objeto serializado para XML com sucesso");


Console.ReadKey();