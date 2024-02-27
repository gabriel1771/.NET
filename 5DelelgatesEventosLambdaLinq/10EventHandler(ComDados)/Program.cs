
//5° estanciar a classe que cria o evento
Pedido pedido = new();

//6° assinar os metodos para o evento
pedido.OnCriarPedido += Email.Send;
pedido.OnCriarPedido += Sms.Send;


//7° chama o metodo que vai disparar o evento para os assinantes
pedido.CriarPedido("teste@gmail.com", 98345345);

Console.ReadKey();

//1° cria a classe que vai ter os dados
class PedidoEventsArgs : EventArgs
{
    public string? Email { get; set; }
    public int Telefone { get; set; }
}


//2° cria a classe que vai criar o evento
class Pedido
{

    //3° cria o evento(agr usando um delegate pré definido que vai conter um evento que agr possui dados e pra isso precisa ser de um tipo(classe
    //com as propiedades(dados)))
    public event EventHandler<PedidoEventsArgs>? OnCriarPedido;

    //4° cria o metodo que vai dispara o evento garantindo que ele vai ter os dados que ele precisa pra isso
    public void CriarPedido(string email, int telefone)
    {
        Console.WriteLine("Criando pedido");

        if (OnCriarPedido != null)
        {
            //Despara o evento para os assinantes e ja passando os valores
            OnCriarPedido(this/*CriarPedidos pedidos = new();*/, new PedidoEventsArgs {Telefone = telefone, Email = email});
        }

    }
}





//aqui são os assinantes

class Sms
{
    public static void Send(object? sender, PedidoEventsArgs e)
    {
        Console.WriteLine("Enviando sms para o numero: " + e.Telefone);
    }
}

class Email
{
    public static void Send(object? sender, PedidoEventsArgs e)
    {
        Console.WriteLine("Enviando email para:" + e.Email);
    }
}