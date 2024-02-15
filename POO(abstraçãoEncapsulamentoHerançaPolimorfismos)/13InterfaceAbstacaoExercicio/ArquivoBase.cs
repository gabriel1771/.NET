using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13InterfaceAbstacaoExercicio;

public abstract class ArquivoBase
{
    public virtual void Nome()
    {
        Console.WriteLine("Defir o nome do arquivo");
    }
}
