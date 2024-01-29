Console.WriteLine("##OPERADORES COMPARATIVOS\n");

/*------------------------------------------------*/
//comparadores 

int x = 10;
int y = 20;

Console.WriteLine($"x > y => {x>y}");
Console.WriteLine($"x < y => {x<y}");
Console.WriteLine($"x >= y => {x>=y}");
Console.WriteLine($"x <= y => {x<=y}");
Console.WriteLine($"x == y => {x==y}");
Console.WriteLine($"x == y => {x==y}");
Console.WriteLine($"x != y => {x!=y}");

/*------------------------------------------------*/
//comparadores para string

string nome1 = "Curso";
string nome2 = "curso";

Console.WriteLine(nome1 == nome2);
Console.WriteLine(nome1.Equals(nome2));

Console.ReadKey();


