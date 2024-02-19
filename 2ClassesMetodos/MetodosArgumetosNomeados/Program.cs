using System.Globalization;

Console.WriteLine("##METODOS COM ARQUMENTOS NOMEADOS##");

Email email = new Email();


//email.Enviar("teste@gmail.com", "Maria", "Era uma vez");


//passando argumento Nomeado
email.Enviar(texto: "bom dia, tudo bem?", endereco: "teste@gmai.com", nome: "Maria");

Console.ReadKey();

public class Email
{
    public void Enviar(string endereco, string nome, string texto)
    {
        Console.WriteLine("Endereço: " + endereco + "\nnome: " + nome + "\nconteudo: " + texto);
    }
}