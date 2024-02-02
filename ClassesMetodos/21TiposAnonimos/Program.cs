Console.WriteLine("##TIPOS ANONIMO##");

//var aluno = new
//{
//    Nome = "Maria",
//    Idade = 43
//};

//Console.WriteLine(aluno.Nome + " " + aluno.Idade);

//Console.WriteLine(aluno.GetType().ToString());

/*---------------------------------------------------------------*/

//var aluno = new
//{
//    Id = 1,
//    Nome = "Kaido",
//    Email = "teste@gmail.com",
//    Endereco = new { Id = 1, Cidade = "fulanopolis", Pais = "Brasil" }
//};

//Console.WriteLine(aluno.Nome);
//Console.WriteLine(aluno.Endereco.Cidade);

/*---------------------------------------------------------------*/

var alunos = new[]
{
    new{Id = 1, Nome = "Maria", Email = "teste@gmail.com"},
    new{Id = 1, Nome = "Sonia", Email = "teste@gmail.com"},
    new{Id = 1, Nome = "Bruno", Email = "teste@gmail.com"}
};

Console.WriteLine(alunos[2].Nome);
Console.WriteLine(alunos[2].Email);

Console.ReadKey();