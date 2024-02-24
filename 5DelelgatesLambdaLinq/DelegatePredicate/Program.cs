

Console.WriteLine("Digite um numero inteiro");
int numero = Convert.ToInt32(Console.ReadLine());

//DelegateIsPar delegateIsPar = DefiniPar;

//Predicate<int> DelegatePar = DefiniPar;
Predicate<int> DelegateEPar = delegate (int x)
{
    return (x % 2 == 0);
}; 

Predicate<int> DelegatePar = x => x % 2 == 0;

if(DelegatePar(numero) /*delegateIsPar(numero)*/)
{
    Console.WriteLine("par");
}
else
{
    Console.WriteLine("impar");
}

Console.ReadKey();

static bool DefiniPar(int num)
{
    if (num % 2 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}


//public delegate bool DelegateIsPar(int num);