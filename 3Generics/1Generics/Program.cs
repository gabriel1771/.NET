
Teste<decimal, int> teste  = new();
Teste<float, float> teste2 = new Teste<float, float>();
//Teste<string, string> teste3 = new Teste<string, string>();

int n1 = 10;
int n2 = 10; 
teste.Comparar(n1, n2);

float n3 = 10; 
float n4 = 10;
teste2.Comparar(n3, n4);

string s1 = "10";
string s2 = "10";
//teste.Comparar(s1, s2);

//teste.Comparar(n1, s2);

teste.Exibir(45.0m);

Console.ReadKey();

//classe só trabalha com tal tipo

//public class Teste
//public class Teste<T1, T2> 
public class Teste<T1, T2> where T1 : struct where T2 : struct //aqui respeita o que a instancia decidir     E struct(significa por valor)
{

    //public void Comparar<T>(T n1, T n2)   //pra qualquer valor dai
   
    public void Comparar(T2 p1, T2 p2)  //aqui respeita o que a classe definir
    {
        bool resultado = p1.Equals(p2);
        Console.WriteLine($"Os tipos: {p1.GetType()}, e {p2.GetType()}");
        Console.WriteLine($"n1, é igual n2 ? {resultado}");
    }

    public void Exibir(T1 n1)
    {
        if(n1 is decimal)
        {
            Console.WriteLine("ta funcionando");
        }
    }


    //public void Comparar(float n1, float n2)
    //{
    //    bool resultado = n1.Equals(n2);
    //    Console.WriteLine($"n1, é igual n2 ? {resultado}");
    //}

    //public void Comparar(string n1, string n2)
    //{
    //    bool resultado = n1.Equals(n2);
    //    Console.WriteLine($"n1, é igual n2 ? {resultado}");
    //}
}