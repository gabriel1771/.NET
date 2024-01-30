Console.WriteLine("##METODOS - PARAMETROS##");


Aluno aluno = new Aluno();

aluno.Consultar();


Console.ReadKey();


public class Aluno
{
    public string? Nome;
    public string ?Sexo;
    public char Aprovado;
    public int Idade;

    public void Consultar()
    {
        Aluno aluno = new Aluno();

        Console.WriteLine("Nome:");
        aluno.Nome = Console.ReadLine();

        Console.WriteLine("Idade:");
        aluno.Idade = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Sexo:");
        aluno.Sexo = Console.ReadLine();

        Console.WriteLine("Para aprovado: (S), Para reprovado: (N)");
        aluno.Aprovado = Convert.ToChar(Console.ReadLine());

        Curso curso = new Curso();

        curso.Resultado(aluno);
    }

}

public class Curso
{
    public void Resultado(Aluno aluno)
    {
        Console.WriteLine($"O aluno {aluno.Nome} de {aluno.Idade} anos de sexo {aluno.Sexo}");
        if(aluno.Aprovado == 'S')
        {
            Console.WriteLine("Foi aprovado!");
        }
        else
        {
            Console.WriteLine("Foi reprovado");
        }
    }
}