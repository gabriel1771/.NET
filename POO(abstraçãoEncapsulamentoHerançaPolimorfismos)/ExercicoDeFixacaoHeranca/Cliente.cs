using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicoDeFixacaoHeranca;

public class Cliente
{
    private string? nome;
    public string? Nome  
    {
        get { return nome; }
        set {
            if (nome == null)
            {
                nome = value;
            }
            else
            {
                Console.WriteLine("nome ja existente");
            }
        }
    }

    private int numero;
    public int Numero
    {
        get { return numero; }
        set
        {
            if (numero == 0)
            {
                numero = value;
            }
            else
            {
                Console.WriteLine("Numero ja existente");
            }
        }
    }
    protected decimal Saldo { get; set; } = 0.00m;


    protected float JurosDepositoPoupanca = 0.005f;
    protected float JurosSaqueInvestimento = 0.001f;
    protected float JurosDepositoInvestimento = 0.009f;

   
    public void ExibirSaldo()
    {
        Console.WriteLine();
        Console.WriteLine($"Nome: {Nome}, Numero: {Numero}");
        Console.WriteLine($"Seu saldo é de: {Saldo}");
        Console.WriteLine("/*-------------------------------------------------------------------*/\n");
    }

    public virtual void OperacaoDeposito(decimal deposito)
    {
        decimal saldo = Saldo;

        saldo += deposito;

        Saldo = saldo;

        Console.WriteLine("Deposito na conta corrente feito com sucesso!");

    }

    public virtual void OperacaoSaque(decimal saque)
    {
        
        Saldo -= saque;
        Console.WriteLine("Saque na conta corrente feito com sucesso!");
        
    }

}
