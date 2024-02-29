using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioList;

public class Aluno
{
    //public string? Nome { get; set; };
    private string? nome;
    public string? Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    //public double Nota { get; set; };
    private double nota;
    public double Nota
    {
        get { return nota; }
        set { nota = value; }
    }

}

