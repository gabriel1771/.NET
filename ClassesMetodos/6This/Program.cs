Console.WriteLine("##THIS##");

//public class Cliente
//{
//    public string Nome;
//    public int Idade;

//    public Cliente(string Nome, int Idade)
//    {
//        this.Nome = Nome;
//        this.Idade = Idade;
//    }
//}

/*----------------------------------------------------------*/

//Teste t1 = new Teste();

//t1.Num1 = 50;
//t1.Num2 = 22;

//t1.Exibir();

//Teste t2 = new Teste();

//t2.Num1 = 45;
//t2.Num2 = 100; 
//t2.Exibir();

//Console.ReadKey();

//public class Teste
//{
//    public int Num1;
//    public int Num2;

//    public void PassarParametro(Teste t)
//    {
//        //esse this é o nome da class
//        Console.WriteLine($"\nthis = {this}");
//        Console.WriteLine($"\nNum1 = {t.Num1}");
//        Console.WriteLine($"\nNum2 = {t.Num2}");
//    }

//    public void Exibir()
//    {
//        //aqui eu to pegando o objeto que está instanciado atualmente
//        PassarParametro(this);
//    }
//}

/*----------------------------------------------------------*/


Teste t1 = new Teste(22);


Console.ReadKey();

public class Teste
{
    public Teste(int num3, int num4)
    {
        Console.WriteLine(num4);
        Console.WriteLine(num3);
    }

    public Teste(int num0, int num1, int num2, int num3, int num4) : this(num3, num4)
    {
        Console.WriteLine(num0);
        Console.WriteLine(num1);
        Console.WriteLine(num2);
    }

    //esse é um exemplo que pode ter varios metodos construturos
    //public Teste(int num, int num0, int num1, int num2, int num3, int num4) : this(num0, num1, num2, num3, num4)
    //{
    //    Console.WriteLine(num);
    //}


    //e aqui mostra que podemos usar constantes para chamar os outros metodos construtures, sem precisar colocar como parametro no construtor primario
    public Teste(int num) : this(2, 7, 10, 100, 10000)
    {
        Console.WriteLine(num);
    }

}