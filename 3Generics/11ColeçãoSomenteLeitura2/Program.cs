
using System.Collections.ObjectModel;

ReadOnlyCollection<ExoPlaneta> exoPlanetas = new(ExoPlaneta.GetExoPlanetas());

/*---------------------------------------------*/
//pode se alterar dados da lista somente leitura se for dados complexos

exoPlanetas[0].Nome = "teste";

foreach (ExoPlaneta item in exoPlanetas)
{
    Console.WriteLine(item.Nome);
}

/*
                  UMA FORMA DE RESOLVER ISSO É CRIANDO UM CAMPO PRIVADA QUE VAI SER UMA LISTA DO TIPO ExoPlaneta 
                  E ENTÃO CRIAR UMA PROPIEDADE QUE ACESSA ESSE CAMPO PRIVADO COM GET E SET CRIANDO A LOGIACA PARA 
                  ADICIONAR ITENS NA LISTA PRIVADA E NO GET RETORNANANDO APENAS O READONLYCOLLECTION.
*/

Console.ReadKey();

class ExoPlaneta
{
    public string? Nome { get; set; }

    public static List<ExoPlaneta> GetExoPlanetas()
    {
        return new List<ExoPlaneta>()
        {
            new ExoPlaneta() { Nome = "Proxima Centauri b" },
            new ExoPlaneta() { Nome = "Kleper 186-7" },
            new ExoPlaneta() { Nome = "Gliesi 1061-c" }
        };
    }

}