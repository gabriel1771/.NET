

try
{
    Console.WriteLine("Informe o Dividendo");
    int dividendo = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Informe o Divisor");
    int divisor = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"Resultado: {dividendo / divisor}");
}
catch (Exception ex) when (DateTime.Now.DayOfWeek == DayOfWeek.Friday) // MUITO CUIDADO PRA NÃO CAUSAR UMA EXCEPTION NA CONDIÇÃO DO CATCH PORQUE 
{                                                                      // ELE NÃO VAI ENTRAR DENTRO DO CATCH E VAI PRO PROXIMO
    Console.WriteLine("não trataremos esse erro agr: SEXTOOOOOU");
    
}
catch (Exception ex) when (ex.Message.Contains("Format"))
{
    Console.WriteLine("Use valores inteiros por favor");
}
catch (Exception ex)
{
    Console.WriteLine("Erro!");
}