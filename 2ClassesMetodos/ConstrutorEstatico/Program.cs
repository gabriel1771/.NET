Console.WriteLine("##CONSTRUTOR ESTATICO##");

//executando o construto statica pela primeira e unica vez até fechar o programa e de pois o parametrizado
Pessoa pessoa = new Pessoa(19, "Maria");

Console.WriteLine(pessoa.Nome + "-" + pessoa.Idade);
Console.WriteLine("Idade Minima" + Pessoa.IdadeMinima);

//executando apenada o construtor parametrizado
Pessoa pessoa2 = new(23, "João");

Console.WriteLine(pessoa.Nome + "-" + pessoa.Idade);
Console.WriteLine("Idade Minima" + Pessoa.IdadeMinima);

Console.ReadKey();
