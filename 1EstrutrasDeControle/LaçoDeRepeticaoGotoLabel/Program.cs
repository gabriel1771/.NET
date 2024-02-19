Console.WriteLine("##LAÇO DE REPETIÇÃO GOTO/LABEL\n");

/*-----------------------------------------------------------*/
//não é muito usado, mas o seu funcionamento praticamente faz com que  cada vez que o compilador encherga a palavra goto ele volta pra parte que 
//o label indicado está definido

int i = 1;

repetir:

    Console.WriteLine($" i = {i}");

    i++;

if (i <= 10)
    goto repetir;

Console.WriteLine("Fim do processamento");

Console.ReadKey();

