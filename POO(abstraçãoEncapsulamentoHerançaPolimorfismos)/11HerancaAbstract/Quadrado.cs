using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11HerancaAbstract;

public class Quadrado : Forma
{
    public double Lado { get; set; }
    public override void CalculaArea()
    {
        Area = Lado * Lado;
    }

    public override void CalculaPerimetro()
    {
        Perimetro = Lado * 4;
    }
}
