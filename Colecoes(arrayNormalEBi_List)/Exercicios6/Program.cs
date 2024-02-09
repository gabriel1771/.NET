
ProcessaObjetos(1, "Maria", 3.45m, null, new Teste());

Console.ReadKey();

static void ProcessaObjetos(params object[] objetos)
{
    foreach (object item in objetos)
    {

        Console.Write("objeto: " + item + "  -  ");
        Console.WriteLine("Tipo: " + item?.GetType() + "\n\n");

    }
}

class Teste { }