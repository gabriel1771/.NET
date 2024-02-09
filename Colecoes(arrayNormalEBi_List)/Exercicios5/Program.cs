
using Exercicios5;

//List<Produto> lista = new() { new Produto() { Nome = "Clips", Preco = 5.99M } };

List<Produto> lista = new();

Produto p1 = new();
p1.Nome = "Clips";
p1.Preco = 3.95M;

lista.Add(p1);

lista.Add(new Produto() { Nome = "Caneta", Preco = 5.99M });
lista.Add(new Produto() { Nome = "Lapís", Preco = 4.15M });
lista.Add(new Produto() { Nome = "Estojo", Preco = 6.99M });
lista.Add(new Produto() { Nome = "Caderno", Preco = 7.55M });

p1.Exibir(lista);

lista.Add(new Produto() { Nome = "Mochila", Preco = 22.44M });

p1.Exibir(lista);

List<Produto> Menor5 = lista.FindAll(x => x.Preco <= 5.00M);

p1.Exibir(Menor5);

Produto p2 = new();
p2 = lista.Find(x => x.Nome.Equals("Estojo"));

Console.WriteLine(p2.Nome + " = " + p2.Preco);

Console.ReadKey();