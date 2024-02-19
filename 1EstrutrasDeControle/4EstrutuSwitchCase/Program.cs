Console.WriteLine("##ESTRUTURA SWITCH CASE##");

int valor = 600;

Console.WriteLine($"Valor da compra: {valor.ToString("c")}");

Console.WriteLine("Digite em quantas vezes se deseja fazer o parcelamento da compra, sendo possivel neste valor de 1-3");

int quantidade = Convert.ToInt16(Console.ReadLine());

switch (quantidade)
{
    case 1:
        Console.WriteLine($"a parcela sera no valor de {valor.ToString("c")}");
        break;
    case 2:
        Console.WriteLine($"a parcela sera no valor de {(valor/2).ToString("c")}");
        break;
    case 3:
        Console.WriteLine($"a parcela sera no valor de {(valor/3).ToString("c")}");
        break;
    default:
        Console.WriteLine("opção invalida");
        break;
}




Console.ReadKey();