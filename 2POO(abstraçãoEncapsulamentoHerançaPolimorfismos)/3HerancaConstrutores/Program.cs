
Aluno aluno1 = new();

Aluno aluno = new("José");

Console.ReadKey();

//base
class Pessoa
{
    public Pessoa()
    {
        Console.WriteLine("construturo da classe Pessoa");
    }

    public Pessoa(string nome)
    {
        Console.WriteLine("construturo da classe Pessoa com argumento");
    }
}

//derivada
class Aluno : Pessoa
{
    public Aluno() : base()/*aqui ele mostra qual construtor chamar na classe base no caso o sem parametro*/
    {
        Console.WriteLine("construtor da clase Aluno");
    }

    public Aluno(string nome) : base (nome) /*e aqui ele chama o com parametro*/
    {
        Console.WriteLine("construtor da clase Aluno com parametro");
    }

}

