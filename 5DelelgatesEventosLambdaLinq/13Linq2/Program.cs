using _13LINQConsultas1;


//fonte de dados (pode ser um IENUMERABLE OU IQUERY
var dados = Produto.GetProdutos();

/*---------------------------------------------*/
//consulta Linq
var eletronicos = dados.Where(x => x.Categoria.Equals("Eletrônicos"));

foreach (var item in eletronicos)
{
    Console.WriteLine(item.Nome + " " + item.Preco);
}

/*---------------------------------------------*/
//consulta com duas condições
var maisCaros = dados.Where(x => x.Preco >= 2000 && x.Estoque > 5);

Console.WriteLine();
foreach (var item in maisCaros)
{
    Console.WriteLine(item.Nome + " " + item.Preco);
}


/*---------------------------------------------*/
//filtro com ordenação
int minino = 10;
var minimoEstoque = dados.Where(x => x.Estoque < 10).OrderBy(x => x.Nome);

Console.WriteLine();
foreach (var item in minimoEstoque)
{
    Console.WriteLine(item.Nome + " " + item.Preco);
}

/*---------------------------------------------*/
//mais de um criterio

var produtosCategoriaNome = dados
                            .OrderBy(x => x.Categoria)
                            .ThenBy(x => x.Nome);

Console.WriteLine();
string itemAntenrior = "";
foreach (var item in produtosCategoriaNome)
{
    if (item.Categoria != itemAntenrior)
    {
        Console.WriteLine(item.Categoria);
        itemAntenrior = item.Categoria;
    }
    Console.WriteLine("      " + item.Nome);
}

/*---------------------------------------------*/
//criar uma lista de strings agr

var listaProdutos = dados.Select(x => x.Nome).OrderBy(x => x);

Console.WriteLine();
foreach ( string item in listaProdutos)
{
    Console.WriteLine(item);
}

/*---------------------------------------------*/
//filtrando por preço, ordenando por nome e adicionando um tipo anonimo(campo que criamos em tempo de execução e VAI SUBSTIUIR OS DADOS DA LISTA QUE 
// ESTA SENDO CRIADA

var resultado = dados
               .Where(x => x.Preco < 500)
               .OrderBy(x => x.Nome)
               .Select(x => new
               {
                   NomeProduto = x.Nome.ToUpper(),
                   PrecoJuros = x.Preco * 1.1
               });

Console.WriteLine();
foreach (var item in resultado)
{
    Console.WriteLine(item.NomeProduto + " " + item.PrecoJuros + item.Esto);
}

/*---------------------------------------------*/
//mesma coisa que anterior porem com desconto de 20% e ordenado por preço

var resultado2 = dados
               .Where(x => x.Preco < 2000)
               .OrderBy(x => x.Preco)
               .Select(x => new
               {
                   NomeProduto = x.Nome.ToUpper(),
                   PrecoDesconto = x.Preco * 0.8
               });

Console.WriteLine();
foreach (var item in resultado2)
{
    Console.WriteLine(item.NomeProduto + " " + item.PrecoDesconto);
}

/*---------------------------------------------*/
//criando uma media com linq

double mediaEletronicos = dados.Where(x => x.Categoria == "Eletrônicos")
                          .Average(x => x.Preco);

Console.WriteLine();
Console.WriteLine(mediaEletronicos);

/*---------------------------------------------*/
//soma de todos os produtos

double soma = dados
              .Where(x => x.Estoque > 0)
              .Sum(x => x.Preco * x.Estoque);

Console.WriteLine($"\n capital: {soma}" );

/*---------------------------------------------*/
//contando

int produtosComEstoqueBaixo = dados.Where(x => x.Estoque < 10).Count();

Console.WriteLine($"\ntotal de produtos com estoque baixo: {produtosComEstoqueBaixo}" );


Console.ReadKey();