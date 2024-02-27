using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11MetodoDeEstexsao_adicionaUmMetodoAOutraClasse_;

//precisa ser public e estatico
public static class EstringExtensions
{
    //tambem precisa ser static public
    public static string InvertString(this string str) //e aqui nos parametros eu cito a classe que eu vou adicionar um metodo
    {
        char[] CharArray = str.ToCharArray();
        Array.Reverse(CharArray);
        string arrayInvertido = new string(CharArray);
        return arrayInvertido;
    }
}
