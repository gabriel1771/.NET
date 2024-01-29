Console.WriteLine("##OPERDADORES LÓGICOS##");

/*------------------------------------------------*/
// variaveis logicas 

bool x = 10 >= 20;
bool y = 10 <= 20;

Console.WriteLine($"x = {x}");
Console.WriteLine($"y = {y}");

/*------------------------------------------------*/
//operador AND -> &&
Console.WriteLine($"x && y = {x && y}");

/*------------------------------------------------*/
//operador OR -> || 
Console.WriteLine($"x || y = {x || y}");

/*------------------------------------------------*/
//operador NOT !
Console.WriteLine($"!(x && y) = {!(x && y)}");

Console.ReadLine();