Console.WriteLine("##OPERADORES DE DECREMENRTO E INCREMENTO##\n");

/*------------------------------------------------*/
//pré incremento

int x = 0;

int valor1 = ++x + 10;
Console.WriteLine($"pre incremento: {valor1} \n");

/*------------------------------------------------*/
//pré decremtento

int y = 0;

int valor2 = --y + 10;
Console.WriteLine($"pre decremento: {valor2} \n");

/*------------------------------------------------*/
//pós incremento

int z = 0;

int valor3 = z++ + 10;
Console.WriteLine($"pós incremento: {valor3} \n");

/*------------------------------------------------*/
//pós decremeto 

int w = 0;

int valor4 = w-- + 10;
Console.WriteLine($"pós decremento: {valor4}\n");


Console.ReadKey();
