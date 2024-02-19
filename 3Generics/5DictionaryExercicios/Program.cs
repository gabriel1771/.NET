/*---------------------------------------------*/
//criando dicionario do tpo aluno(classe)
Dictionary<int, Alunos> alunos = new()
{
    {1, new Alunos("Maria", 7) }, 
    {2, new Alunos("Eric", 9) }, 
    {3, new Alunos("Ana", 10) }, 
    {4, new Alunos("Alex", 5) }, 
    {5, new Alunos("Maria", 4) }, 
};

/*---------------------------------------------*/
//exibindo alunos com classe
ExibirColecao(alunos);


/*---------------------------------------------*/
//alterando valores no dicionario
do
{
    Console.WriteLine("Informe a chave para econtrar o aluno (99 sai)");
    int chave = Convert.ToInt32(Console.ReadLine());
    if (chave == 99) break;

    bool result = alunos.ContainsKey(chave);

    if (result)
    {
        Console.WriteLine("Informe a nota do aluno (1 a 10)");
        int nota1 = Convert.ToInt32(Console.ReadLine());

        alunos[chave].Nota = nota1;
    }
    else
    {
        Console.WriteLine("Aluno não encontrado");
    }

} while (true);

ExibirColecao(alunos);

/*---------------------------------------------*/
//removendo itens no dicionario
do
{
    Console.WriteLine("Informe a chave para remover o aluno (99 sai)");
    int chave = Convert.ToInt32(Console.ReadLine());
    if (chave == 99) break;


    if (alunos.ContainsKey(chave))
    {
        alunos.Remove(chave);
        Console.WriteLine("Aluno removido com sucesso");
    }
    else
    {
        Console.WriteLine("Aluno não encontrado");
    }

} while (true);

ExibirColecao(alunos);

/*---------------------------------------------*/
//incluindo novo itens no dicionario
Console.WriteLine("Informe nome, nota e o codigo do novo aluno: ");
string nome = Console.ReadLine();
int nota = Convert.ToInt32(Console.ReadLine());
int codigo = Convert.ToInt32(Console.ReadLine());

if (!alunos.ContainsKey(codigo))
{
    alunos.Add(codigo, new Alunos(nome, nota));
}
else
{
    Console.WriteLine("este código já existe");
}

ExibirColecao(alunos);


/*---------------------------------------------*/
//ordernar o dicionario com metodo de extenção da linq

IOrderedEnumerable<KeyValuePair<int, Alunos>> alunosOrdenados = alunos.OrderBy(x => x.Value.Nome);

foreach ( KeyValuePair<int, Alunos> item in alunosOrdenados)
{
    Console.WriteLine(item.Value.Nome + ", " + item.Value.Nota);
}

/*---------------------------------------------*/
//esvaziando o dicionario

alunos.Clear();

ExibirColecao(alunos);


Console.ReadKey();

static void ExibirColecao(Dictionary<int, Alunos> alunos)
{
    foreach (KeyValuePair<int, Alunos> item in alunos)
    {
        Console.Write(item.Value.Nome);
        Console.Write(", " + item.Value.Nota + "\n");
    }
}

public class Alunos
{
    public string Nome { get; set; }
    public int Nota { get; set; }
    
    public Alunos(string nome, int nota)
    {
        Nome = nome;
        Nota = nota;
    }

    

}