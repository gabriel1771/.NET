Console.WriteLine("##convercao de tipos: implicita e explicita##");
/*---------------------------------*/
//converções implicitas

int numeroInt = 2145678;
long numeroLong = numeroInt;
float numeroFloat = numeroInt;
double numeroDouble = numeroInt; 
decimal numeroDecimal = numeroInt;

Console.WriteLine(numeroInt);
Console.WriteLine(numeroLong);
Console.WriteLine(numeroFloat);
Console.WriteLine(numeroDouble);
Console.WriteLine(numeroDecimal);

/*
byte - 1 byte
short – 2 bytes
int – 4 bytes
long – 8 bytes
float – 4 bytes
double – 8 bytes
decimal - 16 bytes
*/


/*---------------------------------*/
//converções explicitas

double numeroDouble2 = 12.456;
int numeroInt2 = (int)numeroDouble2;

Console.WriteLine(numeroInt2);

int x = 10;
int y = 4;

float divisao = (float) x / y;

Console.WriteLine(divisao);




Console.ReadKey();