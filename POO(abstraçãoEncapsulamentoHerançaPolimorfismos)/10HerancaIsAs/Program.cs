
/*-----------------------------------------------------------*/
//converteno implicitamente com o cast

//Object carroObj = new Carro();

//try
//{
//	var x = (string)carroObj; //exception
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//    throw;
//}


//Console.ReadKey();

//class Carro { }

/*-----------------------------------------------------------*/
//convertendo com o AS

//Object carroObj = new Carro();

//var x = carroObj as string;

//if(x != null)
//{
//    Console.WriteLine("converteu");
//}
//else
//{
//    Console.WriteLine("não foi possivel converter");
//}


//Console.ReadKey();

//class Carro { }

/*-----------------------------------------------------------*/
////usando as no downcast

//using _9HerancaUpcastingDowncasting;

//Circulo circulo = new Circulo();
//Forma forma = circulo; //upcasting

////Circulo c = (Ciculo)forma;  -- isso vai lançar uma excessão

//Circulo c = forma as Circulo; //downcasting

//if ( c != null)
//{
//    c.PintarCirculo();
//}
//else
//{
//    Console.WriteLine("Operação de downcasting não executada");
//}

/*-----------------------------------------------------------*/
//agr usando o is(que verifica apenas se uma variavel é de tal tipo, se for 
//retorna true se não retorna false

using _10HerancaIsAs;

Circulo circulo = new Circulo();
Forma forma = circulo; // upcasting

if (forma is Circulo) //verifica se o downcast é possivel
{
    Console.WriteLine("Converteu Forma para Circulo\n");

    //((Circulo)forma).PintarCirculo();
    Circulo tipo = forma as Circulo;

    tipo?.PintarCirculo();
}
else
{
    Console.WriteLine("Operação de downcas ting não é possivel");
}

Console.ReadKey();

