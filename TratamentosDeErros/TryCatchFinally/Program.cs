/*---------------------------------------------*/

//try
//{
//    Console.WriteLine("Informe o Dividendo");
//    int dividendo = Convert.ToInt32(Console.ReadLine());

//    Console.WriteLine("Informe o Divisor");
//    int divisor = Convert.ToInt32(Console.ReadLine());

//    Console.WriteLine($"Resultado: {dividendo / divisor}");

//    Console.ReadKey();
//}
//catch (Exception e)
//{

//    Console.WriteLine($"\n {e.GetType()} informa : {e.Message}"); //mais simples
//    Console.WriteLine($"\n {e.Message} ");
//    Console.WriteLine($"\n {e.StackTrace} "); //exibe a pilha
//    Console.WriteLine($"\n {e.Source} "); //mais resumida
//}

/*---------------------------------------------*/


try
{
    Console.WriteLine("Informe o Dividendo");
    int dividendo = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Informe o Divisor");
    int divisor = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"Resultado: {dividendo / divisor}");

    Console.ReadKey();
}
catch (FormatException)
{

    Console.WriteLine("\n informe um valor inteiro");

}
catch (OverflowException)
{
    Console.WriteLine("\n informe um valor inteiro entre 1 a 999999");
}
catch (DivideByZeroException)
{
    Console.WriteLine("\n para o denominador informe um valor diferente de zero");
}
catch (Exception)
{
    Console.WriteLine("Ocorreu um erro");
}