Console.WriteLine("##ASSINATURA DE METODOS - SOBRECARGA##");

Email email = new Email();

email.Enviar("teste@gmail.com");
email.Enviar("teste@gmail.com", "oportunidade de emprego");
email.Enviar("teste@gmail.com", 2000);
email.Enviar(2000, "teste@gmail.com");

Console.ReadKey();

public class Email
{
    public void Enviar(string? endereco)
    {
        Console.WriteLine(endereco);
        Console.WriteLine("Mensagem Padrão");
        Console.WriteLine();
    }

    public void Enviar(string? endereco, string? assunto)
    {
        Console.WriteLine(endereco);
        Console.WriteLine(assunto);
        Console.WriteLine();
    }

    public void Enviar(string? endereco, decimal valor)
    {
        Console.WriteLine(endereco);
        Console.WriteLine("Proposta Comercial");
        Console.WriteLine(valor);
        Console.WriteLine();
    }

    public void Enviar(decimal valor, string? endereco)
    {
        Console.WriteLine(endereco);
        Console.WriteLine("Proposta Comercial");
        Console.WriteLine(valor);
        Console.WriteLine();
    }
}