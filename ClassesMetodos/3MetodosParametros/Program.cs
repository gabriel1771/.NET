Console.WriteLine("##METODOS E PARAMETROS##");

MinhaClasse minhaClasse = new MinhaClasse();

minhaClasse.Saudacao("Maria", DateTime.Now.ToLongDateString());


Console.ReadKey();

class MinhaClasse
{
    public void Saudacao(string nome, string data)
    {
        Console.WriteLine(nome);
        Console.WriteLine(data);
    }
}