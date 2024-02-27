using System.Runtime.Serialization.Formatters.Binary;

namespace _1SerializacaoBinaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string caminho = @"C:\Users\reisg\OneDrive\Desktop\devBack\LinguagemC#\7Serializacao\1SerializacaoBinaria\serializacao.bin";

            Aluno aluno = new("Maria", 2, 20, "maria@gmail.com");

            using (FileStream fs = new(caminho,
                                       FileMode.OpenOrCreate,
                                       FileAccess.ReadWrite))
            {
#pragma warning disable SYSLIB0011
                var bf = new BinaryFormatter();
                bf.Serialize(fs, aluno);
#pragma warning disable SYSLIB0011

                Console.WriteLine("tecle algo para continuar");
                Console.ReadKey();

                fs.Seek(0, SeekOrigin.Begin);
                var objetoDeserializado = (Aluno)bf.Deserialize(fs);
                Console.WriteLine(objetoDeserializado.Nome);
            }
            Console.WriteLine("Serialização binaria concluida");

            Console.ReadKey();
        }
    }
}
