
using _15LINQAdrupamentos1;

List<Produto> listaProdutos = Produto.GetProdutos();


//aqui eu to criando uma coleção de grupos organizados pela chave = categoria
var gruposDeProdutos = listaProdutos.GroupBy(x => x.Categoria)
                       .OrderBy(x => x.Key);

//agr vou exibir os grupos e os itens nos mesmos
foreach (/*Dictionary<string, Produto>*/ var grupos in gruposDeProdutos)
{
    Console.WriteLine(grupos.Key);

    foreach ( Produto item in grupos)
    {
        Console.WriteLine($"nome: {item.Nome}, preco: {item.Preco}");
    }
}

/*---------------------------------------------*/
//agr vou ordenar por produto, pra isso preciso criar um tipo anonimo(altera ou substitui um item que faz parte da coleção onde está o .Select)
//aqui no caso acontece isso 1.cria grupos por categoria, 2.ordena esses grupos segundo o nome das categorias, 3.cria um tipo anonimo na coleção de grupos(ou seja cada grupo 
//vira uma coleção anonima onde pode ser substituidos valores ou alterados), 4. cria-se dois campos no tipo anonimo onde se subtitui o grupo com produtos, 5.um desses campos é uma 
//lista ordenada de objeto pelo nome, 6. se cria mais um metodo anonimo onde cada objeto agr é um tipo anonimo de 3 campos 
var produtosPorCategoria = listaProdutos
                           .GroupBy(p => p.Categoria)
                           .OrderBy(c => c.Key)
                           .Select(g => new
                           {
                               Categoria = g.Key,
                               Produtos = g.OrderBy(p => p.Nome)
                               //.Select(p => new                                    //aqui eu deixei comentado para provar a ideia que se isso não 
                               //{                                                   // acontece-se seria apenas uma coleção de tipos anonimos
                               //    Nome = p.Nome,                                  // ordenados pelo campo categoria e possuindo outro campo 
                               //    Preco = p.Preco,                                // que no caso é uma coleção de objetos ordenados pelo nome
                               //    Estoque = p.Estoque                             // ou seja ainda os produtos(objetos) são originais sem alterações pelo .Select
                               //})
                           });

Console.WriteLine();
foreach ( var grupos in produtosPorCategoria)
{
    Console.WriteLine(grupos.Categoria);

    foreach (var item in grupos.Produtos)
    {
        Console.WriteLine($"nome:{item.Nome}, preco: {item.Preco}, {item.Id}");
    }
}

Console.ReadKey();