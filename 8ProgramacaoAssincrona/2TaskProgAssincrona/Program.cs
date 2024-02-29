using _2TaskProgAssincrona;

/* 
         UM METODO ASSINCRONO É UM METODO QUE RETORNA UMA TAREFA, ELA PODE SER VOID OU ESSA TAREFA PODE RETORNAR UM INT...
         E EU SO POSSO OBTER O VALOR RETORNADO DE UMA TAREFA QUANDO EU USO A PALAVRA AWAIT(ESPERO A TAREFA ACABAR) E O METODO QUE 
         TIVER A PALAVRA AWAIT PRECISA TER TAMBEM A PALAVRA ASYNC, NO CASO PARA TAREFAS QUE NÃO RETORNAM NADA NÃO PRECISA DAI
*/

Console.WriteLine("## Café da manha Síncrono ##");
CafeDaManha();

Console.WriteLine("##Café da manha Assíncrono ##");
CafeDaManhaAsync();

Console.ReadKey();

static async void CafeDaManhaAsync()
{
    //aqui vai chamar esse metodo e quando perceber que ele é um metodo async, vai deixar processando e vai pular pra próxima linha 
    Console.WriteLine("\n -- Preparar o café");
    Task<Cafe> /*var*/ tarefaCafe = PrepararCafeAsync();

    Console.WriteLine("\n -- Preparar o pão");
    Task<Pao> /*var*/ tarefaPao = PrepararPaoAsync();

    //aqui só quando as tarefas tarefaCafe e tarefaPao estiver prontas que as variaveis cafe e pao vão receber os objetos instanciados
    //nas respectivas classes ou seja aqui o codigo volta a ser sincrono e espera a primeira tarefa retornar o que ela promete e de pois 
    //faz o mesmo com a outra 
    var cafe = await tarefaCafe;
    var pao = await tarefaPao;

    //aqui quando as variaveis estiverem preenchidas então vai executar este metodo
    ServirCafe(cafe, pao);
}

static void CafeDaManha()
{
    Console.WriteLine("\n -- Preparar o café");
    var cafe = PrepararCafe();

    Console.WriteLine("\n -- Preparar o pão");
    var pao = PrepararPao();

    ServirCafe(cafe, pao);
}

static void ServirCafe(Cafe cafe, Pao pao)
{
    Console.WriteLine("\n>>Servindo o cafe da manhã");
    Thread.Sleep(2000);
    Console.WriteLine(">>Café servido");
}

static async Task<Cafe> PrepararCafeAsync()
{
    Console.WriteLine("-Fervendo a água");
    //metodo de pausa assincrono
    await Task.Delay(2000);
    Console.WriteLine("-Coando o café");
    await Task.Delay(2500);
    Console.WriteLine("-Adoçando o café");
    return new Cafe();
}
static Cafe PrepararCafe()
{
    Console.WriteLine("-Fervendo a água");
    //metodo de pausa sincrono
    Thread.Sleep(2000);
    Console.WriteLine("-Coando o café");
    Thread.Sleep(2500);
    Console.WriteLine("-Adoçando o café");
    return new Cafe();
}


static async Task<Pao> PrepararPaoAsync()
{
    Console.WriteLine("-Partir o pão");
    await Task.Delay(2000);
    Console.WriteLine("-Passar manteiga no pão");
    await Task.Delay(2000);
    Console.WriteLine("-Tostar o pão");
    return new Pao();
}

static Pao PrepararPao()
{
    Console.WriteLine("-Partir o pão");
    Thread.Sleep(2000);
    Console.WriteLine("-Passar manteiga no pão");
    Thread.Sleep(2000);
    Console.WriteLine("-Tostar o pão");
    return new Pao();
}