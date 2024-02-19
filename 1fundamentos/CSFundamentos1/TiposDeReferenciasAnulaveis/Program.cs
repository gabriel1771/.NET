Console.WriteLine("##REFERENCIAS ANULAVEIS##\n");

/*----------------------------------------------*/
//definindo a variavel como uma possivel variavel null 

string? nome = null;

//ou 

//string nome = "";

/*----------------------------------------------*/
//agr fazendo uma verificação, se for null não faça nada, mas se tiver algum valor execute o metodo ou ação
//nesse caso estou usando o metodo que todas as variaveis do tipo string tem 
Console.WriteLine(nome?.ToUpper());


Console.ReadLine();