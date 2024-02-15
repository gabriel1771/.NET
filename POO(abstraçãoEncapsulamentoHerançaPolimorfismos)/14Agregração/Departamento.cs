using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14Agregração;

internal class Departamento
{


    public string? Nome { get; set; }
    private List<Professor>? professores { get; set; }
    public Departamento(string? nome)
    {
        Nome = nome;
        professores = new List<Professor>();
    }

    public void IncluirProfessor(Professor professor)
    {
        professores?.Add(professor);
    }

    public void ListaProfessor()
    {
        Console.WriteLine($"Departamento: {Nome}");

        foreach (Professor item in professores)
        {
            Console.WriteLine($"Nome: {item.Nome}, Disciplina: {item.Disciplina}");
        }
    }

}
