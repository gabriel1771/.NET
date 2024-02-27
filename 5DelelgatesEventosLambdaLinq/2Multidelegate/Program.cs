MeuDelegate DelegateMulticast = new(Metodo1);

DelegateMulticast += Metodo2;
DelegateMulticast += Metodo3;

DelegateMulticast("multiCast Delegate");

DelegateMulticast -= Metodo3;

DelegateMulticast("multiCast Delegate");



Console.ReadKey();

static void Metodo1(string mensagem)
{
    Console.WriteLine($"Metodo 1: {mensagem}");
}

static void Metodo2(string mensagem)
{
    Console.WriteLine($"Metodo 2: {mensagem}");
}

static void Metodo3(string mensagem)
{
    Console.WriteLine($"Metodo 3: {mensagem}");
}

public delegate void MeuDelegate(string mansagem);