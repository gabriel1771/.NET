using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicoDeFixacaoHeranca;

internal class Poupanca : Cliente
{

    public override void OperacaoDeposito(decimal deposito)
    {
        decimal saldo = Saldo;

        saldo += deposito;

        saldo += (saldo * (decimal)JurosDepositoPoupanca);

        

        Saldo = saldo;

        Console.WriteLine("Deposito na popança feito com sucesso!");

    }

    public override void OperacaoSaque(decimal saque)
    {
        if(Saldo >= saque)
        {
            Saldo -= saque;
            Console.WriteLine("Saque na poupança feito com sucesso!");
        }
        else
        {
            Console.WriteLine("Saldo insuficiente");
        }
    }

}
