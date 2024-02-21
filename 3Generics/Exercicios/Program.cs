/*---------------------------------------------*/
//8)

//List<int> numeros = new();

//numeros.Add(7);
//numeros.Add(2);

/*---------------------------------------------*/
//9)

//List<Aluno> alunos = new()
//{
//    {new Aluno(){Nome = "Maria", Idade = 18, Sexo = 'F' } },
//    {new Aluno(){Nome = "Joao", Idade = 20, Sexo = 'M' } },
//    {new Aluno(){Nome = "Ana", Idade = 18, Sexo = 'F' } }
//};

//Exibir(alunos);

//Console.ReadKey();

//static void Exibir(List<Aluno> lista)
//{
//    foreach (Aluno item in lista)
//    {
//        Console.WriteLine( item.Nome + " " + item.Idade + " " + item.Sexo);
//        Console.WriteLine();
//    }
//}

//public class Aluno
//{
//    public string Nome { get; set; }
//    public int Idade { get; set; }
//    public char Sexo { get; set; }
//}

/*---------------------------------------------*/
//10)

//string expression = "(1 + 2) * 3) - 4";
//bool balenceada = EstaBalanceada(expression);
//Console.WriteLine($"A expressão matemática {expression} é {(balenceada ?
// "esta balanceada" : "não esta balanceada")}.");
//Console.ReadKey();
//static bool EstaBalanceada(string expression)
//{
//    Stack<char> stack = new Stack<char>();
//    foreach (char c in expression)
//    {
//        if (c == '(' || c == '{' || c == '[')
//        {
//            stack.Push(c);
//        }
//        else if (c == ')' || c == '}' || c == ']')
//        {
//            if (stack.Count == 0)
//            {
//                return false;
//            }
//            char lastParentheses = stack.Pop();
//            if ((c == ')' && lastParentheses != '(') ||
//            (c == '}' && lastParentheses != '{') ||
//            (c == ']' && lastParentheses != '['))
//            {
//                return false;
//            }
//        }
//    }
//    return stack.Count == 0;
//}

/*---------------------------------------------*/
//11)
//Queue<string> printQueue = new Queue<string>();
//printQueue.Enqueue("Arquivo1.pdf");
//printQueue.Enqueue("Arquivo2.docx");
//printQueue.Enqueue("Arquivo3.ppt");
//while (printQueue.Count > 0)
//{
//    string file = printQueue.Dequeue();
//    Console.WriteLine($"\nO arquivo \"{file}\" está sendo impresso...");
//    Thread.Sleep(new Random().Next(1000, 5000));
//    Console.WriteLine($"O arquivo \"{file}\" foi impresso com sucesso.");
//}
//Console.ReadKey();

/*---------------------------------------------*/
//12)




