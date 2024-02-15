
/*-------------------------------------------------------------------*/
//impede a herança de outras classes



//Cliente cli = new();
////cli.Nome = "José";
//cli.ExibeNome();


//Console.ReadKey();



//sealed class Pessoa
//{
//    public string? Nome { get; set; }

//    public  void ExibeNome()
//    {
//        Console.WriteLine($"\nMeu nome é {Nome}");
//    }

//}

//class Cliente /*: Pessoa*/
//{
//    public /*new*/ void ExibeNome()
//    {
//        //Console.WriteLine($"\nMeu nome é {Nome}");
//    }
//}

/*-------------------------------------------------------------------*/
//impede que se sobreescreva novamente aquele metodo para as classes que 
//iram herdar a mesma, fazendo assim a possibilidade de sobreescrever apenas as
//classes anteriores a ela e a mesma





Console.ReadKey();

class ClasseBase
{

    protected virtual void Metodo1()
    {
        Console.WriteLine("Classe.Base.Metodo1()");
    }

    protected virtual void Metodo2()
    {
        Console.WriteLine("Classe.Base.Metodo2()");
    }
}

class Classe1 : ClasseBase
{
    sealed protected override void Metodo1()
    {
        Console.WriteLine("Classe.Base.Metodo1()");
    }

    protected override void Metodo2()
    {
        Console.WriteLine("Classe.Base.Metodo2()");
    }
}

class Classe2 : Classe1
{
    protected override void Metodo1()
    {
        Console.WriteLine("Classe.Base.Metodo1()");
    }

    protected override void Metodo2()
    {
        Console.WriteLine("Classe.Base.Metodo2()");
    }
}