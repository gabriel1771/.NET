using _9HerancaUpcastingDowncasting;

/*-----------------------------------------------------------*/
//upcasting(torna um objeto da classe derivada para um objeto da classe base

////Forma circulo = new Circulo(10, 20); //upcasting
//Circulo circulo = new Circulo(10, 20); //upcasting

//Forma forma = circulo;

//circulo.Desenhar(); 

//forma.Desenhar(); //não consegue acessar o metodo pintar da classe circulo


//Console.WriteLine(forma == circulo);


/*-----------------------------------------------------------*/
//downcasting(torna um objeto da classe base para um objeto da classe derivada)

Circulo circulo = new Circulo(20, 20);

Forma f = circulo; //upcasting

Circulo c = (Circulo)f; //downcasting

c.Desenhar();
c.PintarCirculo();

Console.WriteLine(c == f);
Console.WriteLine(c == circulo);


Console.ReadKey();