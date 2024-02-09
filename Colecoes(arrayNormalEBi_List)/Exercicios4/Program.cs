
using Exercicios4;
using System.Collections;

/*------------------------------------------------*/
//a) e b)
ArrayList lista = new();

for (int i = 0; i< 3; i++)
{
    Console.WriteLine("Digite nome e idade: ");

    lista.Add(new Pessoa { Nome = Console.ReadLine(), Idade = Convert.ToInt32(Console.ReadLine()) });

}

/*------------------------------------------------*/
//c)

Pessoa.Exibir(lista);

/*------------------------------------------------*/
//d)

lista.Add(new Pessoa { Nome = "Jaime", Idade = 20 });
lista.Add(new Pessoa { Nome = "Tânia", Idade = 18 });
Pessoa.Exibir(lista);

/*------------------------------------------------*/
//e) 

int index = lista.Count;
--index;
lista.RemoveAt(index);
Pessoa.Exibir(lista);



Console.ReadKey();


