using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios1;

public class Carro : IVeiculos
{
    public int quantidade { get; set; }

    public Carro(int quantidade)
    {
        this.quantidade = quantidade;
    }

    public void Dirigir()
    {
        if(quantidade > 0)
        {
            Console.WriteLine("Dirigindo");
        }
        else
        {
            Console.WriteLine("sem gasolina");
        }
    }

    public bool Abastecer(int quantidade)
    {
        
        this.quantidade += quantidade;
        return true;
    }
}
