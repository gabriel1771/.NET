
Gato gato = new() { Nome = "bichano" };
gato.ExibeNome();

Cachorro cao = new() { Nome = "pipoca" };
cao.ExibeNome();



Console.ReadKey();

//classe base
class Animal
{
    public string? Nome {  get; set; }


    public virtual void ExibeNome()
    {
        Console.WriteLine($"\nMeu nome é {Nome}");
    }
}

class Gato : Animal
{
    public override void ExibeNome()
    {
        Console.WriteLine($"\nEu sou um gato Meu nome é {Nome}");
    }
}

class Cachorro : Animal
{
    
}

