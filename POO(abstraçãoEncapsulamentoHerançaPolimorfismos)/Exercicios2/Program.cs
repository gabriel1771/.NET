
using Exercicios2;

LivroFotos livro = new();
Console.WriteLine(livro.NumPaginas);

LivroFotos livro2 = new(24);
Console.WriteLine(livro2.NumPaginas);

SuperLivroFotos livro3 = new();
Console.WriteLine(livro3.NumPaginas);

Console.ReadKey();