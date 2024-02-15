using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8HerancaTipos
{
    internal class Quardrado : Forma , Icusto
    {
        public int GetArea()
        {
            return (lado * lado);
        }

        public int GetCusto(int area)
        {
            return area * 10;
        }
    }
}
