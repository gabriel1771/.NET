Console.WriteLine("##PRECEDENCIA NOS OPERADORES##");

/*------------------------------------------------*/
//prioridade 

int a = 5, b = 6, c = 4;

int r = --a * b - ++c;

Console.WriteLine(r);
Console.WriteLine();



/*------------------------------------------------*/
//segue a mesma prioridade

int resultado = a = b = c;

Console.WriteLine(resultado);

Console.ReadLine();
