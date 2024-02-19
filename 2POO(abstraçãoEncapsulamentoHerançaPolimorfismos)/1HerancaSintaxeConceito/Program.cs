
Funcionario funci = new();
funci.Nome = "José";
funci.Email = "teste@gmail.com";
funci.Empresa = "Google Inc.";
funci.Salario = 9000;

Console.WriteLine("Funcionario");
Console.WriteLine(funci.Empresa);
Console.WriteLine(funci.Salario);
funci.Identificar();



Aluno aluno = new Aluno();

aluno.Nome = "José";
aluno.Email = "teste@gmail.com";
aluno.Curso = "Engenharia";
aluno.Nota = 9;

Console.WriteLine("\nAluno\n");
Console.WriteLine(aluno.Curso);
Console.WriteLine(aluno.Nota);
funci.Identificar();




Console.ReadKey();

public class Pessoa
{
    public string? Nome { get; set; }
    public string? Email { get; set; }

    public void Identificar()
    {
        Console.WriteLine($"{Nome} - {Email}");
    }
}


public class Funcionario : Pessoa
{
    public string? Empresa { get; set; }
    public decimal Salario { get; set; }

}

public class Aluno : Pessoa
{
    public string? Curso { get; set; }
    public int Nota { get; set; }

}