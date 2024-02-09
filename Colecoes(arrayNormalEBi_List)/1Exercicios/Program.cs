/*------------------------------------------------*/
//a)

string[] frutas = new string[10] { "Maça", "Banana", "Laranja", "Uva", "Manga", "Pêra", "Abacate", "Mamão", "Pêssego", "Amora" };

int cont = 0;

foreach (string item in frutas)
{
    cont++;
}

Console.WriteLine($"Quantiadae de frutas no array:{cont} \n");

ExibirArray(frutas, cont);

/*------------------------------------------------*/
//b)

Console.WriteLine($"\nprimeiras: {frutas[0]}");
Console.WriteLine($"penultima: {frutas[8]}");


/*------------------------------------------------*/
//c)

frutas[2] = "Kiwi";
frutas[9] = "Caqui"; 

ExibirArray(frutas, cont);

/*------------------------------------------------*/
//d)

Array.Sort(frutas);

ExibirArray(frutas, cont);

/*------------------------------------------------*/
//d)

Array.Reverse(frutas);
ExibirArray(frutas, cont);

Console.ReadKey();

static void ExibirArray(string[] frutas, int cont)
{
    Console.WriteLine();
    for (int i = 0; i < cont; i++)
    {
        Console.WriteLine(frutas[i]);
    }

    Console.WriteLine();
}