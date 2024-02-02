Console.WriteLine("##DIVISÃO DE NUMERO INTEIRSOS##");

Console.WriteLine("x / y");

Console.WriteLine("Informe valores x e y");

int x = Convert.ToInt32(Console.ReadLine());    
int y = Convert.ToInt32(Console.ReadLine());



try //codigo a ser monitorado
{
    int z = x / y;

    Console.WriteLine("resposta = " + z);
}
catch (Exception ex)  // só se estourar um erro (excessão)
{
    Console.WriteLine("\nNão existe divizão por zero tente outro numero!");
    Console.WriteLine($"\nERRO: << {ex.Message} >>");
    Console.WriteLine($"\nDetalhes:  {ex?.StackTrace?.ToString()} ");
}
finally //sempre sera executado
{
    Console.WriteLine("processamento concluido");
}