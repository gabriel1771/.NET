/*---------------------------------------------*/
//criando

/* SO PRA FIM DIDADICO*/
HashSet<string> timesSP = new() { "Santos", "Palmeiras", "São Paulo" };
HashSet<string> timesRJ = new() { "Vasco", "Flamengo", "Fluminencw" };
HashSet<string> timesBH = new() { "Bahia", "Vitoria", "Juazeiro", "São Paulo" };

HashSet<string> timesMundiais = new() { "Santos", "Palmeiras", "São Paulo", "Flamengo" };

/*---------------------------------------------*/
//add e remove (retornam true ou false)

if (!timesSP.Contains("Corinthians"))
{
    timesSP.Add("Corinthians");
    timesSP.Add("Santos");
   
}

bool resultado = timesBH.Remove("Jazeiro");


/*---------------------------------------------*/
//verificando se é um subconjunto 

if (timesSP.IsSubsetOf(timesMundiais))
{
    Console.WriteLine("é subconjunto");
}

/*---------------------------------------------*/
//é um supeconjunto 

if (timesMundiais.IsSupersetOf(timesSP))
{
    Console.WriteLine("é superconjunto");
}

/*---------------------------------------------*/
//possui elementos de outro conjunto

if (timesRJ.Overlaps(timesMundiais))
{
    Console.WriteLine("possue elementos em comum");
}

/*---------------------------------------------*/
//unindo conjuntos

timesSP.UnionWith(timesRJ);
timesSP.UnionWith(timesBH);

Console.WriteLine();
ExibirColecao(timesSP);


/*---------------------------------------------*/
//ordenando o conjunto existente

SortedSet<string> todosTimes = new(timesSP);

ExibirColecao(todosTimes);

/*---------------------------------------------*/
//intersecção entre conjunto

timesSP.IntersectWith(timesMundiais);

ExibirColecao(timesSP);

/*---------------------------------------------*/
//(diferença)remove os itens da coleção que invoca o metodo, que são iguais em ambos os 2 conjuntos

ExibirColecao(timesBH);
//timesBH.ExceptWith(timesMundiais);
Console.WriteLine("\n\ndiferença:");
ExibirColecao(timesBH);

/*---------------------------------------------*/
//juntas os elementos que estão apenas em um cojunto e apenas no outro
Console.WriteLine("\n\n");
timesBH.SymmetricExceptWith(timesMundiais);
ExibirColecao(timesBH);

/*---------------------------------------------*/
//remover todos itens

timesMundiais.Clear();
Console.WriteLine("fim");
ExibirColecao(timesMundiais);







Console.ReadKey();

static void ExibirColecao<T>(IEnumerable<T> colecao)
{
    Console.WriteLine();
    foreach (T item in colecao)
    {
        Console.WriteLine(item);
    }
}