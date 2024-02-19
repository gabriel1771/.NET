using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9StackUndo;

public class EditorTexto
{
    private Stack<char> UndoStack = new();
    private string Texto = " ";

    public void Digitar(char c)
    {
        Texto += c;
        UndoStack.Push(c);
        Console.WriteLine($"texto: {Texto}");
    }

    public void Undo()
    {
        if (UndoStack.Count > 0)
        {
            char ultiMochar = UndoStack.Pop();
            Texto = Texto.Substring(0, Texto.Length - 1);
            Console.WriteLine("----" + Texto);
        }

    }
}
    