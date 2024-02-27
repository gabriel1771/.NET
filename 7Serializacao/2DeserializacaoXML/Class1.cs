using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DeserializacaoXML;

public class Aluno
{

    public string Nome { get; set; } = string.Empty;
    public int Id { get; set; }
    public string Email { get; set; } = string.Empty;
    public int Idade;

    public Aluno() { }

    public Aluno(string nome, int id, int idade, string email)
    {
        Nome = nome;
        Id = id;
        Idade = idade;
        Email = email;
    }

}
