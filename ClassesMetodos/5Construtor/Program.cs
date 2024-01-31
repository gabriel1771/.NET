Console.WriteLine("##CONTRUTOR##");

//Aluno aluno = new Aluno(22, "Feminino", 'S'); se não tiver essa chamada ai pode usar assim ou só passando o nome
Aluno aluno = new Aluno("Maria", 22, "Feminino", 'S');


Console.WriteLine(aluno.Nome == null ? "null" : aluno.Nome);
Console.WriteLine(aluno.Idade == 0 ? "0" : aluno.Idade);
Console.WriteLine(aluno.Sexo == null ? "null" : aluno.Sexo);
Console.WriteLine(aluno.Aprovado == null ? "null" : aluno.Aprovado);

Console.ReadKey();

public class Aluno
{
    public string? Nome;
    public string? Sexo;
    public char? Aprovado;
    public int Idade;

    public Aluno(string nome)
    {
        Nome = nome;
    }

    public Aluno(string nome, int idade, string sexo, char aprovado) : this(nome)
    {
        Idade = idade;
        Sexo = sexo;
        Aprovado = aprovado;
    }

}