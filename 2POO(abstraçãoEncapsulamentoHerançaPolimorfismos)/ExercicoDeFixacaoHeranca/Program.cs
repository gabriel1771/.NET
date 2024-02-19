

using ExercicoDeFixacaoHeranca;

Cliente corrente = new() { Numero = 111, Nome = "Maria" };
Poupanca poupanca = new() { Numero = 2, Nome = "Gracieli" };
Investimento investimento = new() { Numero = 3, Nome = "Maria" };

corrente.ExibirSaldo();
poupanca.ExibirSaldo();
investimento.ExibirSaldo();

corrente.OperacaoDeposito(1000);
corrente.OperacaoSaque(100);
corrente.ExibirSaldo();

poupanca.OperacaoDeposito(1000);
poupanca.OperacaoSaque(100);
poupanca.ExibirSaldo();

investimento.OperacaoDeposito(1000);
investimento.OperacaoSaque(100);
investimento.ExibirSaldo();



corrente.OperacaoSaque(2000);
corrente.ExibirSaldo();

poupanca.OperacaoSaque(2000);
poupanca.ExibirSaldo();

investimento.OperacaoSaque(2000);
investimento.ExibirSaldo();

Console.ReadKey();