using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15Acoplamento_ComAgrAss_;

public class Homem : Animal
{
    //private readonly ComportamentoAndar _ComportamentoAndar;
    public readonly ComportamentoAndar _ComportamentoAndar;

    public Homem(ComportamentoAndar comportamentoAndar)
    {
        _ComportamentoAndar = comportamentoAndar;
    }

    public void Locomocao()
    {
        Console.WriteLine(nameof(Homem));
        _ComportamentoAndar.Andar();
    }
}
