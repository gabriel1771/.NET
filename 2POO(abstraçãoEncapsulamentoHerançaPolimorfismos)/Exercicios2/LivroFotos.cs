using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios2;

public class LivroFotos
{
    private int numPaginas;
    public int NumPaginas
    {
       get { return numPaginas; }
       set { numPaginas = value; }
    }

    public LivroFotos() => NumPaginas = 16;
    public LivroFotos(int num)
    {
        NumPaginas = num;
    }
    
}
