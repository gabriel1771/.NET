using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios4;

public class Pessoa
{
    public string Nome { get; set; }

    public string ToString()
    {
        return "nome:" + Nome;
    }
}
