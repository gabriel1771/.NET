using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19ModificadoresDeAcesso;
internal class MinhaStruct
{
    int MeuCampo;
    string? MinhaPropiedade { get; set; }

    void MeuMetodo()
    {
        Console.WriteLine("Minha Struct");
    }
}

