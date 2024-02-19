Console.WriteLine("Definindo dados do tipo string, objects e dynamic");
Console.WriteLine();

string nome = "linguagem c#";
string titulo = "curso de c#";

Console.WriteLine(nome);
Console.WriteLine(titulo);

Console.WriteLine();

// não é recomendado usar string para trabalhar com texto porque cada vez que eu altero uma mesma variavel string, ela cria e armazena um espaço novo na 
// memoria 

object numero = 2;
object condicao = true;
object nota = 2.5;
object nome1 = "gabriel";
object letra = 'A';

Console.WriteLine(numero);
Console.WriteLine(condicao);
Console.WriteLine(nota);
Console.WriteLine(nome1);
Console.WriteLine(letra);

Console.ReadLine();