using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicoDeFixacaoHeranca;

public class Investimento : Cliente
{
    public override void OperacaoDeposito(decimal deposito)
    {
        decimal saldo = Saldo;

        saldo += deposito;

        saldo += (saldo * (decimal)JurosDepositoInvestimento);

        

        Saldo = saldo;

        Console.WriteLine("Deposito na conta investimento feito com sucesso!");

    }

    public override void OperacaoSaque(decimal saque)
    {
        decimal desconto = (Saldo * (decimal)JurosSaqueInvestimento);

        if (Saldo >= (desconto + saque))
        {
            Saldo -= desconto;
            Saldo -= saque;    //se não fosse para exercicitar, daria pra juntar todos os descontos pra poupar operações
            Console.WriteLine("Saque na conta de investimento feito com sucesso!");
        }
        else
        {
            Console.WriteLine("Saldo insuficiente");
        }
    }
}
