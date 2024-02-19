using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios5;

public class Produto
{
    public string? Nome { get; set; }
    public decimal Preco { get; set; }
    
    public void Exibir(List<Produto> l)
    {
        decimal soma = 0;
        Console.WriteLine();
        foreach (Produto item in l)
        {
            soma += item.Preco;
            Console.WriteLine($"{item.Nome} =  {item.Preco.ToString("c")}");
        }

        Console.WriteLine($"\nTotal de produtos: {l.Count()}");
        Console.WriteLine($"\nMedia de preços: {Math.Round((soma / l.Count()), 2)}");
        Console.WriteLine();
    }
}
