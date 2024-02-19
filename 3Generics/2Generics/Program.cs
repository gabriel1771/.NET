
ClasseGenerica<string> objStr = new();

objStr.Adicionar("10");
objStr.Adicionar("20");
objStr.Adicionar("30");
objStr.Adicionar("40");
objStr.Adicionar("50");

for (int i = 0; i< 5; i++)
{
    Console.WriteLine(objStr[i]);
}


Console.ReadKey();

//classe generica(PARA QUALQUE DADOS QUE EU DEFINIR NA INSTANCIA) com indexadores para o campo array
public class ClasseGenerica<T>
{
    public T[] obj = new T[5];
    public int contador = 0;


    public void Adicionar(T item)
    {
        if (contador < 5)
        {
            obj[contador++] = item;
        }
    }

    //indexador
    public T this[int index]
    {
        get { return obj[index]; }
        set { obj[index] = value; }
    }
}