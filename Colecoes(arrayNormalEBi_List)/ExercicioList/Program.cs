using ExercicioList;

//

//List<Aluno> lista = new();
//lista = FonteDados.GetAlunos();

List<Aluno> lista = FonteDados.GetAlunos();

ExibirAlunos(lista);

ExibirAlunos(lista);

lista.Add(new Aluno() { Nome = "Bia", Nota = 7.75 });
lista.Add(new Aluno() { Nome = "Mario", Nota = 8.95 });

ExibirAlunos(lista);

//int index = lista.FindIndex(i => /*i.Nome.Contains("Amanda")*/ i.Nome == "Amanda");
//lista.RemoveAt(index);

Aluno aluno1 = lista.Find(i => i.Nome.Equals("Amanda"));

lista.Remove(aluno1);

ExibirAlunos(lista);

//alunos.Sort();
List<Aluno> listaOrdenada = lista.OrderBy(n => n.Nome).ToList();

ExibirAlunos(listaOrdenada);

var alunosNotaOito = lista.FindAll(n => n.Nota >= 8);

//foreach (Aluno item in alunosNotaOito)
//{
//    Console.WriteLine(item.Nome);
//}

Console.WriteLine("Alunos com nota igual ou maior que 8");
ExibirAlunos(alunosNotaOito);


Console.ReadKey();

static void ExibirAlunos(List<Aluno> lista)
{
    double soma = 0;

    foreach (Aluno item in lista)
    {
        Console.WriteLine(item.Nome + ", " + item.Nota);
        soma += item.Nota;
    }

    Console.WriteLine();

    Console.WriteLine($"Media das notas é: {Math.Round((soma / lista.Count()), 2)}");

    Console.WriteLine($"Quantidade de alunos: {lista.Count()}\n\n");
}