Console.WriteLine("##PARAMETRO OPCIONAL##");

Console.WriteLine("Digite o destino");
string? destino = Console.ReadLine();

Console.WriteLine("Digite o titulo");
string? titulo = Console.ReadLine();

Console.WriteLine("Digite o texto");
string? texto = Console.ReadLine();

Email email = new();

email.Enviar(destino, texto:texto);

Console.ReadKey();


public class Email
{
    public void Enviar(string endereco = "Destino padrão", string titulo = "Titulo padrão", string texto = "Assunto padrão")
    {
        Console.WriteLine("\nEndereço: " + endereco + "\nnome: " + titulo + "\nconteudo: " + texto);
    }
}