
Console.WriteLine("## Saidad De DADOS ##");

int idade = 25;
string nome = "Maria";

/*---------------------------------*/
//concatenação
Console.WriteLine("/*-----------------Concatenacao----------------*/");
Console.Write(nome + " tem " + idade + " anos. \n");
Console.WriteLine("");

/*---------------------------------*/
//interpolação(mais usado)
Console.WriteLine("/*----------------Interpolacao-----------------*/");
Console.WriteLine($"{nome} tem {idade} anos \n");

/*---------------------------------*/
//place holders(antigamente usado, pareciso com c)
Console.WriteLine("/*----------------Place Holders-----------------*/");
Console.WriteLine("{0} tem {1} anos \n", nome, idade);

Console.ReadKey();



