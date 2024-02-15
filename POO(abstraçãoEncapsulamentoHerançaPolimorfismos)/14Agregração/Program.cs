//associação: uma classe se associa a outra ou tambem não precisam se associar (agregação mais fraco)
//agregação: uma classe pode existir sem a classe base, mesmo as duas se relacionando (composição mais fraco)
//composição: uma classe não pode existir sem a classe base


using _14Agregração;

Professor prof1 = new("Carlos", "Química");
Professor prof2 = new("Maria", "Ingês");
Professor prof3 = new("Ana", "Literatura");
Professor prof4 = new("Paulo", "Matemática");

Departamento dep1 = new("Exatas");

dep1.IncluirProfessor(prof1);
dep1.IncluirProfessor(prof4);
dep1.ListaProfessor();


Departamento dep2 = new("Humanas");

dep2.IncluirProfessor(prof2);
dep2.IncluirProfessor(prof3);
dep2.ListaProfessor();


Console.ReadKey();

