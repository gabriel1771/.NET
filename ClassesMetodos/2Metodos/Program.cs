Console.WriteLine("##MÉTODOS##");

MinhaClasse minhaClasse = new();

minhaClasse.Saudacao();

Console.ReadKey();


class MinhaClasse
{
    public void Saudacao()
    {
        Console.WriteLine("Bom - Vindo!");
        DataAtual();

    }

    public void DataAtual() => Console.WriteLine(DateTime.Now.ToShortDateString());
    

}

