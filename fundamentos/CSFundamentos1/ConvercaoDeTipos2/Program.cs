Console.WriteLine("##Converção de Tipos 2##");

/*-------------------------------------*/
//valor numerico para string usando metodo da class object

int valorInt = 123;
double valorDouble = 12.45;
decimal valorDecimal = 12.45678m;

string s1 = valorInt.ToString();
string s2 = valorDouble.ToString();
string s3 = valorDecimal.ToString();

Console.WriteLine($"{s1} \n");
Console.WriteLine($"{s2} \n");
Console.WriteLine($"{s3} \n");


/*-------------------------------------*/
//class convert namespace system

int valorInt2 = 10;
double valorDouble2 = 5.35;
bool valorBool = true;

Console.WriteLine("/*-------------------------------------*/");
Console.WriteLine(Convert.ToString(valorInt2));
Console.WriteLine(Convert.ToDouble(valorInt2));
Console.WriteLine(Convert.ToString(valorBool));
Console.WriteLine(Convert.ToInt32(valorDouble2));

/*-------------------------------------*/
// valor very large or very small to type Byte convert

int varInt = 10000;
Console.WriteLine(Convert.ToByte(varInt));


Console.ReadKey();