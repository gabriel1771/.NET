Console.WriteLine("##BREAK CONTINUE##");

/*----------------------------------------------------*/

//string opcao;

//for (; ; )
//{
//    Console.WriteLine("Digite algo (X PARA SAIR)");
//    opcao = Console.ReadLine();

//    if (opcao == "X" || opcao == "x")
//    {
//        Console.WriteLine("Tchau\n");
//        break;
//    }
//}

/*----------------------------------------------------*/

//for( int i=0 ; i<=10; i++)
//{
//    if(i == 4)
//    {
//        continue;
//    }

//    Console.WriteLine(i);
//}



/*----------------------------------------------------*/


int n = 0; 

while ( n <= 10)
{
    if ( n == 5)
    {
        n++;
        continue; 
    }

    Console.WriteLine(n);
    n++;
}


Console.WriteLine("Fim do processamento\n");


