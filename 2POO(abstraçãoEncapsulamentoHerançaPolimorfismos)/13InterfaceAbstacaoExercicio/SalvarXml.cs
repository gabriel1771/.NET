using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13InterfaceAbstacaoExercicio;

public class SalvarXml : ArquivoBase, ISalvar
{
    public void Salvar()
    {
        Console.WriteLine("Salvar arquivo Xml");
    }

    public override void Nome()
    {
        Console.WriteLine("Definir nome Xml");
    }
}
