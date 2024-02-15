

ClasseDerivada cd = new();
cd.VerificarAcesso();

Console.ReadKey();

public class ClasseDerivada : ClasseBase
{
    public void VerificarAcesso()
    {
        Public_Membro();
        Pretected_Membro();
        Protected_Internal_Membro();
        Internal_Membro();
        //Private_Membro();

        //Acesso ao campo private usando uma propiedade
        int soma = public_var + protected_var + internal_var + Private_var;

        Console.WriteLine($"Total soma: {soma}");

    }
}

public class ClasseBase
{

    //campos
    public int public_var = 1;
    protected int protected_var = 2;
    internal int internal_var = 3;
    private int private_var = 4;

    //propiedade 
    public int Private_var
    {
        get { return private_var; }
        set { private_var = value; }
    }

    public void Public_Membro()
    {
        Console.WriteLine("Classe - Métodos Public");
    }

    protected void Pretected_Membro()
    {
        Console.WriteLine("ClasseBase - Método Protected");
    }

    internal void Internal_Membro()
    {
        Console.WriteLine("ClasseBase - Método Internal");
    }

    protected internal void Protected_Internal_Membro()
    {
        Console.WriteLine("ClasseBase - Método preotected internal");
    }

    private void Private_Membro()
    {
        Console.WriteLine("ClasseBase - Método private");
    }
}
