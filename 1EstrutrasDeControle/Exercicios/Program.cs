Console.WriteLine("##EXERCICIOS##\n");

/*-------------------------------------------------------------*/
//1

//double numero1, numero2, numero3, numeroMaior;

//Console.WriteLine("\nDigite  o primeiro numero:");
//numero1 = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("\nDigite  o segundo numero:");
//numero2 = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("\nDigite  o terceiro numero:");
//numero3 = Convert.ToDouble(Console.ReadLine());

//numeroMaior = numero1;

//if (numeroMaior < numero2) numeroMaior = numero2;
//if (numeroMaior < numero3) numeroMaior = numero3;

//if (numeroMaior == numero1)
//{
//    Console.WriteLine($"O primeiro numero: {numeroMaior} é o maior");
//}
//else if (numeroMaior == numero2)
//{
//    Console.WriteLine($"O segundo numero: {numeroMaior} é o maior");
//}
//else if (numeroMaior == numero3)
//{
//    Console.WriteLine($"O terceiro numero: {numeroMaior} é o maior");
//}

/*-------------------------------------------------------------*/
//2

//float a, b, c;

//float r1, r2, delta;

//Console.Write("Informe o valor de a: ");
//a = Convert.ToInt32(Console.ReadLine());

//Console.Write("\nInforme o valor de b: ");
//b = Convert.ToInt32(Console.ReadLine());

//Console.Write("\nInforme o valor de b: ");
//c = Convert.ToInt32(Console.ReadLine());

//delta = (float) (Math.Pow(b, 2)) + (-4 * a * c);


//if(delta < 0)
//{
//    Console.WriteLine("As raizes são imaginarias;\nSem solução para os numeros reais.");
//}
//else
//{

//    r1 = (float) (-b + Math.Sqrt(delta)) / (2 * a);
//    r2 = (float)(-b - Math.Sqrt(delta)) / (2 * a);

//    if(r1 != r2)
//    {
//        Console.WriteLine("Ambas as raizes são reais e diferentes");
//    }
//    else
//    {
//        Console.WriteLine("ambas as raizes são reais e de valor igual");
//    }

//    Console.WriteLine($"Primeira raiz x1 = {r1}");
//    Console.WriteLine($"Segunda raiz x2 = {r2}");

//}

/*-------------------------------------------------------------*/
//3

//a)

//int soma = 0, cont = 0;

//while (cont < 10)
//{
//    soma += ++cont;
//    Console.WriteLine(cont);
//}

//Console.WriteLine($"soma: {soma}");


//b)

//int soma = 0, cont = 0;

//do
//{
//    ++cont;
//    soma += cont;
//    Console.WriteLine(cont);
//} while (cont < 10);

//Console.WriteLine($"soma = {soma}");

//c)

//int soma = 0;

//for (int cont = 0; cont <= 10; cont++)
//{
//    soma += cont;
//    Console.WriteLine(cont);
//}

//Console.WriteLine($"soma = {soma}");

/*-------------------------------------------------------------*/
//4

//float? num;

//string? condicao = null;

//while (true)
//{

//    if (condicao == "SAIR") break;

//    Console.WriteLine("Digite o número maior que zero e que deseja ver seus multiplos");
//    num = Convert.ToSingle(Console.ReadLine());

//    if (num > 0)
//    {
//        for (int i = 1; i < 11; i++)
//        {
//            Console.WriteLine($"{num} X {i} = {num * i}");
//        }
//    }
//    else
//    {
//        Console.WriteLine("Numero menor que zero! Por favor digite um numero maior que zero");
//    }

//    Console.WriteLine("\nDigite SAIR para sair par fechar o programa");
//    condicao = Console.ReadLine();

//}


/*-------------------------------------------------------------*/
//5

//char? resposta = null; 

//while(resposta != 'x') 
//{
//    Console.WriteLine("Qual a instrução para sair de um loop?");
//    Console.WriteLine("a.quit\nb.continue\nc.break\nd.exit");
//    Console.WriteLine("Qual a opção correta? (Tecle x para sair)");
//    resposta = Convert.ToChar(Console.ReadLine());

//    if(resposta == 'x')
//    {

//    }
//    else if(resposta == 'c')
//    {
//        Console.WriteLine("Resposta correta!");
//    }
//    else
//    {
//        Console.WriteLine("Resposta incorreta!");
//    }
//}

/*-------------------------------------------------------------*/
//6

//a)

//for (int i = 10; i <= 20; i += 2)
//{
//    if (i != 16)
//    {
//        Console.WriteLine(i);
//    }
//}


//b)

//for(int i = 10; i<=20; i++)
//{
//    if(i != 16 && i % 2 == 0)
//    {
//        Console.WriteLine(i);
//    }
//}

//c)

//int i = 9; 

//while(true)
//{
//    i++; 
//    if(i != 16 && i % 2 == 0)
//    {
//        Console.WriteLine(i);
//    }
//    else
//    {
//        if(i > 20)
//        {
//            break;
//        }
//        else
//        {
//            continue;
//        }

//    }
//}


/*-------------------------------------------------------------*/
//7

//for (int i = 0, j = 0; j <= 4; ++i, ++j)
//{
//    int k = i;
//    while(k != 0)
//    {
//        Console.Write("*");
//        k--;
//    }

//    Console.WriteLine();
//}

/*-------------------------------------------------------------*/
//8

//int n, i, f;

//Console.WriteLine("digite o numero que se deseja fazer o fatorial");
//n = Convert.ToInt32(Console.ReadLine());

//f = n;

//for (i = n - 1; i >= 1; i--)
//{
//    f *= i;
//}

//Console.WriteLine(f);

/*-------------------------------------------------------------*/
//9

//int i = 2;

//do
//{
//    for (int j = 1; j <= 10; j++)
//    {
//        Console.WriteLine($"{j} X {i} = {j * i}");
//    }

//    Console.WriteLine();
//    i++;
//} while (i <= 6);

/*-------------------------------------------------------------*/
//10

//string? entrada;
//double nota;

//while (true)
//{
//    Console.WriteLine("Digite sua nota:   (para sair digite: SAIR)");
//    entrada = Console.ReadLine();

//    if (entrada != "SAIR")
//    {
//        nota = Convert.ToDouble(entrada);
//        switch (nota)
//        {
//            case 10:
//                Console.WriteLine("A+");
//                break;

//            case >= 9:
//                Console.WriteLine("A");
//                break;

//            case >= 7:
//                Console.WriteLine("B");
//                break;

//            case >= 6:
//                Console.WriteLine("C");
//                break;

//            case >= 5:
//                Console.WriteLine("E");
//                break;

//            default:
//                Console.WriteLine("F");
//                break;
//        }
//    }
//    else
//    {
//        break;
//    }
//}

/*-------------------------------------------------------------*/
//11

double n1, n2, resultado;

string? sair;

char operador;

while (true)
{
    Console.WriteLine("Digite primeiro valor  ou  (SAIR para sair):");
    sair = Console.ReadLine();

    if (sair == "SAIR")
    {
        break;
    }
    else
    {
        n1 = Convert.ToDouble(sair);

        Console.WriteLine("digite operador: ");
        operador = Convert.ToChar(Console.ReadLine());

        Console.WriteLine("digite o segundo numero: ");
        n2 = Convert.ToDouble(Console.ReadLine());

        switch (operador)
        {
            case '+':
                Console.WriteLine($"{n1} + {n2} = {n1 + n2}\n");
                break;
            case '-':
                Console.WriteLine($"{n1} - {n2} = {n1 - n2}\n");
                break;
            case '*':
                Console.WriteLine($"{n1} X {n2} = {n1 * n2}\n");
                break;
            case '/':
                if (n2 == 0)
                {
                    Console.WriteLine("divisão por zero = infinito");
                }
                else
                {
                    Console.WriteLine($"{n1} / {n2} = {n1 / n2}\n");
                }
                break;
            default:
                Console.WriteLine("operador invalido!");
                break;
        }
    }
}




Console.ReadKey();