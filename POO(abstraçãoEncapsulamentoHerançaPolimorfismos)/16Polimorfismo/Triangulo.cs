using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16Polimorfismo;

public class Triangulo : Figura
{
    public override void Desenhar()
    {
        Console.WriteLine("Desenhando triangulo...");
        base.Desenhar();
    }
}
