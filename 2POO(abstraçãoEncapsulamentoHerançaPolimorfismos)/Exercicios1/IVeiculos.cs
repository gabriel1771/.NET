using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios1;

 interface  IVeiculos
{
    public int quantidade {  get; set; }

    public void Dirigir();
    public bool Abastecer(int quantidade);
}
