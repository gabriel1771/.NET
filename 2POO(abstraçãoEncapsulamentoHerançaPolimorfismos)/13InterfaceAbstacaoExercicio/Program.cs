
using _13InterfaceAbstacaoExercicio;

SalvarXml salvarXml = new();
salvarXml.Salvar();
salvarXml.Nome();

SalvarJson salvarJson = new();
salvarJson.Salvar();
salvarJson.Nome();


//unico jeito de usar um metodo implementado de uma interface
ISalvar salvarArquivo = new SalvarJson();

Console.ReadLine();