/*---------------------------------------------*/
//sobreescrevendo os dois metodos de comparação
//PORQUE SE NÃO SOBREESCREVE QUANDO SE TRATA DE UMA INSTANCIA, ELE PEGA O CODIGO HASH DA REFERENCIA E NÃO DO VALOR, MESMA COISA PARA O EQUALS

Pessoa p1 = new(1234567, "Maria");
Pessoa p2 = new(1234567, "joao");
Pessoa p3 = new(2134235, "Maria");

Console.WriteLine(p1.Equals(p2));
Console.WriteLine(p1.GetHashCode());
Console.WriteLine(p2.GetHashCode());


Console.ReadKey();

public class Pessoa
{

    public string Nome { get; set; }
    public int Cpf { get; set; }

    public Pessoa(int cpf, string nome)
    {
        this.Cpf = cpf;
        this.Nome = nome;
    }

    //SOBREESCREVENDO UM METODO DA PLATAFORMA .NET (OBJECT)
    public override bool Equals(object? obj)
    {
        if (obj == null) return false;
        if (!(obj is Pessoa)) return false;

        Pessoa other = (Pessoa)obj;

        return this.Cpf.Equals(other.Cpf);

        //return base.Equals(obj);

    }

    public override int GetHashCode()
    {
        //PORQUE SE O VALOR FOR IGUAL, PARA .NET, ELE ARMAZENA O MESMO CODIGO HASH
        return this.Nome.GetHashCode();
        //return base.GetHashCode();
    }


}