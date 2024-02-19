Console.WriteLine("##ESTRUTURA DE CONTROLE IF##");

Console.WriteLine("Cliente Especial? TRUE/FALSE");

bool resposta = Convert.ToBoolean(Console.ReadLine());

//if(resposta == "S" || resposta == "s") 
//{
//    Console.WriteLine("Descontao de 10%");
//}

if (resposta)
{
    Console.WriteLine("Desconto de 10%");
}

Console.WriteLine("Fim do processamento");


/*-----------------------------------------------------------------*/

Console.ReadKey();