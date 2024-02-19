using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13InterfaceAbstacaoExercicio;

internal interface ISalvar
{
    void Salvar();

    void compactar()
    {
        Console.WriteLine("Compactando arquivos");
    }
}
