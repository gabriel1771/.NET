
using _14LINQConsultas2;

//funte de dados
List<Produto> listaProdutos = Produto.GetProdutos();


/*---------------------------------------------*/
//primeiro elemento da sequencia
Produto primeiroProduto = listaProdutos.First();

Console.WriteLine(primeiroProduto.Nome);

/*---------------------------------------------*/
//first com criterio porem comando first se não encontrarem nada eles criam uma exception

try
{
    Produto primeiroElemento = listaProdutos.First(x => x.Nome.Equals("Cadeira"));
    Console.WriteLine($"\n {primeiroElemento.Nome}  {primeiroElemento.Preco}");
}
catch (Exception ex)
{

    Console.WriteLine(ex.Message);
}

/*---------------------------------------------*/
//firstOrDefoult esse retorna um valor null caso não encontre nada

Produto primeiro1 = listaProdutos.FirstOrDefault(x => x.Nome.Equals("Cadeira"));

if (primeiro1 != null)
{
    Console.WriteLine(primeiro1.Nome);
}
else
{
    Console.WriteLine("Produto não encontrado");
}

/*---------------------------------------------*/
//mesma coisa pra Last porem esse retorna o ultimo elemento com exception

/*---------------------------------------------*/
//mesma coisa pro lastOrDefault retorna null se não encontra

/*---------------------------------------------*/
//mesma coisa para o single (unico elemento com tal criterio)

try
{
    Produto primeiroElemento2 = listaProdutos.Single(x => x.Nome.Equals("Cadeira "));
    Console.WriteLine($"\n {primeiroElemento2.Nome}  {primeiroElemento2.Preco}");
}
catch (Exception ex)
{

    Console.WriteLine(ex.Message);
}

/*---------------------------------------------*/
//mesma coisa para o singleOrderfault e retorna null se não tiver o elemento E SE TIVER MAIS DE UM RETORNA UMA EXCEPTION

Console.ReadKey();