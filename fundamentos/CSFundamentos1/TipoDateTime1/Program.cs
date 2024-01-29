Console.WriteLine("## Struct DateTime ## \n");

DateTime data = DateTime.Now;

Console.WriteLine(data);

Console.WriteLine();

//definindo data especifica
DateTime dataAnoNovo = new DateTime(2024, 01, 01);
Console.WriteLine(dataAnoNovo);

//definindo data com horas, minutos e segundos
Console.WriteLine();
DateTime DataComHoras = new DateTime(2024, 01, 05, 14, 00, 00);
Console.WriteLine(DataComHoras);


//usando os nomes dos campos(QUE PODEM SER, VARIAVEIS COM TIPOS PRIMITIVOS, METODOS, ATRIBUTOS, IDEXADORES E EVENTOS) da struct do tipo DateTime
//conseguimos (adicionar horas, pegar só dia ou só dia da semana ...)
Console.WriteLine();

DateTime tempo = DateTime.Now;

//Console.WriteLine(tempo.Year);
//Console.WriteLine(tempo.Day);
//Console.WriteLine(tempo.Second);

Console.WriteLine($"Data do dia de hoje: {tempo} \n");

Console.WriteLine($"da qui 5 dias vai ser {tempo.AddDays(5)} \n");

//dia da semana e dia do ano

Console.WriteLine($"da que 5 dias vai ser o dia da semana: {tempo.DayOfWeek} \n");
Console.WriteLine($"e vai ser o dia do ano: {tempo.DayOfYear} \n");

//data no formato long e short 
Console.WriteLine(tempo.ToLongDateString());
Console.WriteLine($"{tempo.ToShortDateString()} \n");

//tempo no formato long and short
Console.WriteLine(tempo.ToLongTimeString());
Console.WriteLine($"{tempo.ToShortTimeString()} \n");




Console.ReadKey();