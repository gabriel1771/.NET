using _16Polimorfismo;

/*-----------------------------------------------------------------------*/
//polimorfismo Dinamicos

List<Figura> figuras = new() { new Triangulo(), new Circulo()};

foreach ( Figura item in figuras)
{
    item.Desenhar();
}

/*-----------------------------------------------------------------------*/

Console.ReadKey();