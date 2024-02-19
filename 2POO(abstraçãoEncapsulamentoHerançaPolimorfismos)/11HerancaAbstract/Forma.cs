using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11HerancaAbstract;

public abstract class Forma
{
    public string Cor {  get; set; }
    public double Area { get; set; }
    public double Perimetro { get; set; }

    //métodos abstratos
    public abstract void CalculaArea();

    public abstract void CalculaPerimetro();

    //método comum

    public string Descricao()
    {
        return "Sou a classe Forma";
    }
}
