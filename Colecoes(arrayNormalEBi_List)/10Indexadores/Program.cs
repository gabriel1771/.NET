using _10Indexadores;

/*---------------------------------------------*/
//Os indexadores, é uma forma de usar um array(coleção) que pertence a uma classe.

Time time = new Time();

time[1] = "Inter";
time[2] = "Santos";

string valor1 = time[1];
string valor2 = time[2];

Console.WriteLine(valor1);
Console.WriteLine(valor2);

Console.ReadKey();