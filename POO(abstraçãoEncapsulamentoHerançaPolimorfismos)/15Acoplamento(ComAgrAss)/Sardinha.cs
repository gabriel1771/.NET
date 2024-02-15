using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15Acoplamento_ComAgrAss_;

public class Sardinha : Animal
{
    //private readonly ComportamentoNadar _ComportamentoNadar;
    public readonly ComportamentoNadar _ComportamentoNadar;

    public Sardinha(ComportamentoNadar comportamentoNadar)
    {
        _ComportamentoNadar = comportamentoNadar;
    }

    public void Locomocao()
    {
        Console.WriteLine(nameof(Sardinha));
        _ComportamentoNadar.Nadar();
    }
}
