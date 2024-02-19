using _9StackUndo;

EditorTexto editor = new();

editor.Digitar('S');
editor.Digitar('T');
editor.Digitar('A');
editor.Digitar('C');
editor.Digitar('Q');

editor.Undo();
editor.Digitar('K');





Console.ReadKey();