
Aluno aluno = new();

aluno[0] = "Maria";

Console.WriteLine(aluno[0]);

string estudante = aluno[0];

Console.WriteLine(estudante);

Console.ReadKey();

public class Aluno
{
    string[] nomes = new string[10];

    public string this[int i]
    {
        get {return nomes[i]; }
        set {nomes[i] = value; }
    }
}