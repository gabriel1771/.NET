using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios4;

public class Pessoa
{
    public string? Nome { get; set; }
    public int Idade { get; set; }

    public static void Exibir(ArrayList l)
    {
        Console.WriteLine();
        for (int i = 0; i < l.Count; i++)
        {
            Pessoa p0 =  (Pessoa)l[i];
            Console.WriteLine(p0.Nome);
            Console.WriteLine(p0.Idade);
        }
        Console.WriteLine();

    }
}
