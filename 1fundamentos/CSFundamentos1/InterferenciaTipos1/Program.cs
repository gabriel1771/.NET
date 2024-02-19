Console.WriteLine("##INTERFERENCIA DE TIPOS##");

/*-------------------------------------------------*/
//var, tipo de dados que se adapta com o valor recebido na variavel

var idade = 22;
var nome = "Gabriel";
var salario = 2500.00m;

Console.WriteLine($"{nome} tem {idade} anos e seu salario é:{salario.ToString("c")}");

/*-------------------------------------------------*/
//não pode 

//var salario = null; 

//var titulo;

//var salario, titulo, esporte;

var numero = 10;
numero = numero + 1;
//numero = "gabriel";

/*-------------------------------------------------*/
//pode ser usado para tipos pré-definidos também

var teste = new Teste();
teste.MeuMetodo();

Console.ReadKey();

class Teste
{
    public void MeuMetodo()
    {
        Console.WriteLine("Meu método");
    }
}

