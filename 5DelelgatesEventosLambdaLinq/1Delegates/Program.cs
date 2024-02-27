
using _1Delegates;

float resultado = Calculadora.Somar(10, 40);

Console.WriteLine(resultado);

//1° forma de  atribuir metodo(instanciar o metodo) e usar
DelegateCalculadora calc = new DelegateCalculadora(Calculadora.Somar);
float resultado1 = calc.Invoke(10, 20);
Console.WriteLine(resultado1);


//2° forma de atribuir metodo e usar (mais usado)
DelegateCalculadora calc2 = Calculadora.Somar;
float resultado2 = calc2(20, 30);
Console.WriteLine(resultado2);

//3° forma de atribuir metodo e usar
DelegateCalculadora calc3 = (float n1, float n2) => Calculadora.Somar(n1, n2);
float resultado3 = calc3(20, 30);
Console.WriteLine(resultado3);

/*---------------------------------------------*/
//usando a mesma variavel porem para outros metodos

calc = Calculadora.Dividir;
float resultado4 = calc(20, 30);
Console.WriteLine(resultado4);

calc = Calculadora.Multiplicar;
float resultado5 = calc(20, 30);
Console.WriteLine(resultado5);

calc = Calculadora.Subtrair;
float resultado6 = calc(20, 30);
Console.WriteLine(resultado6);



Console.ReadKey();


public delegate float DelegateCalculadora(float n1, float n2);