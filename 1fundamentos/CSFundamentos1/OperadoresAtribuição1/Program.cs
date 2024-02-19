using System.Drawing;
Console.WriteLine("##OPERADORES DE ATRIBUIÇÃO##\n");

/*---------------------------------------------------*/
//usando os operadores de atribuição com tipos numericos 

//var x = 10;
float x = 10;

Console.WriteLine($"O valor inicial de x é: {x}");
Console.WriteLine($"x+= 5 => {x+=5}");
Console.WriteLine($"x-= 3 => {x-=3}");
Console.WriteLine($"x*= 4 => {x*=4}");
Console.WriteLine($"x/= 5 => {x/=5}");
Console.WriteLine($"x%= 5 => {x%=5}");

/*---------------------------------------------------*/
//usando a atribuição em strings

//var y = "123";
string y = null;


Console.WriteLine($"\nvalor inicial de y: {y}");
Console.WriteLine($"y+=\"456\" => {y+="456"}");


Console.ReadKey();
