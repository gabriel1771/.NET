

List<string> lista = new();

lista.Add("Maria");
lista.Add("João");
lista.Add("Paulo");
lista.Add("Mirim");
lista.Add("Carlos");

//string result = lista.Find(VerificaNomeLista);
string result = lista.Find(nome => nome.Equals("Paulo"));

Console.WriteLine(result);

Console.ReadKey();

