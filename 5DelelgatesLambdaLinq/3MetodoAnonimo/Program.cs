
/*---------------------------------------------*/
//criando função anonima

//Imprimir imprimir = delegate (int num)
//{
//    Console.WriteLine("\n numero: " + num + "metodo anonimo");
//};

//imprimir(100);
//imprimir(200);




//Console.ReadKey();

//public delegate void Imprimir(int num);

/*---------------------------------------------*/
//usando função anonima na lista

List<string> lista = new();

lista.Add("Maria");
lista.Add("João");
lista.Add("Paulo");
lista.Add("Mirim");
lista.Add("Carlos");

//string result = lista.Find(VerificaNomeLista);
string result = lista.Find(delegate (string nome)
{
    return nome.Equals("João");
});

Console.WriteLine(result);

Console.ReadKey();

//static bool VerificaNomeLista(string nome)
//{
//    Console.WriteLine($"consultando nome: {nome}");
//    return nome.Equals("João");
//}