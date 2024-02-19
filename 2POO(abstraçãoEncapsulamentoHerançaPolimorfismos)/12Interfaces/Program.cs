
IControle d = new Demo();

d.Nome = "Teste";
d.Desenhar();
d.Exibir();

Console.ReadKey();

interface IControle
{

    void Desenhar();

    string Nome { get; set; }

    public void Exibir()
    {
        Console.WriteLine("teste");
    }

    //public IControle() { }

    //int status(é um campo ou atributo que não pode ser statico, precisa ser
    //instanciado para ser acessessado)

   


}

interface IGrafico
{
    void Pintar();
}


public class Demo : IControle, IGrafico
{

    public string Nome { get; set; } = string.Empty;

    public void Desenhar()
    {
        Console.WriteLine("Desenhando");
    }

    public void Pintar()
    {
        Console.WriteLine("pintando"); 
    }
}
