Console.WriteLine("##ESTRUTURA SWITCH CASE 2##");

/*-------------------------------------------------------------------*/
//varios cases para um codigo só
Console.WriteLine("Digite o nome do mês");

string? mes = Console.ReadLine();

if(mes != null) mes.ToLower();

switch (mes)
{
    case "janeiro":
    case "março":
    case "maio":
    case "julho":
    case "agosto":
    case "outubro":
    case "dezembro":
        Console.WriteLine("Este mês tem 31 dias");
        break;
    case "fevereiro":
        Console.WriteLine("Este mês tem 28 á 29 dias");
        break;
    default:
        Console.WriteLine("Este mês tem 30 dias");
        break;
}

Console.WriteLine();

/*-------------------------------------------------------------------*/
//um switch dentro do outro

Console.WriteLine("Digite se você é um Gerente(1) ou Programador(2)");
int funcao = 0, cargo = 0;
cargo = Convert.ToInt32(Console.ReadLine());

if(cargo == 2)
{
    Console.WriteLine("Digite se você é junior(1), pleno(2) ou senior(3)");
    funcao = Convert.ToInt32(Console.ReadLine());
}

switch (cargo)
{
    case 1:
        Console.WriteLine("Bem vindo Gerente");
        break;
    case 2:
        switch(funcao)
        {
            case 1:
                Console.WriteLine("Bem vindo programador junior");
                break;
            case 2:
                Console.WriteLine("Bem vindo programador pleno");
                break;
            case 3:
                Console.WriteLine("Bem vindo programador senior");
                break;
            default:
                Console.WriteLine("Função desconhecida");
                break;
        }
        break;
    default:
        Console.WriteLine("Não consigo te identificar");
        break;
}

Console.WriteLine("Fim do processamento");
Console.ReadKey();