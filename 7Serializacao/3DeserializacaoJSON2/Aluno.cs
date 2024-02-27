using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace _3DeserializacaoJSON2;

public class Aluno
{

    public string Nome { get; set; } = string.Empty;

    [JsonIgnore]
    public int Id { get; set; }

    public string Email { get; set; } = string.Empty;

    public int Idade { get; set; }


    public Aluno() { }

    public Aluno(string nome, int id, int idade, string email)
    {
        Nome = nome;
        Id = id;
        Idade = idade;
        Email = email;
    }

}
