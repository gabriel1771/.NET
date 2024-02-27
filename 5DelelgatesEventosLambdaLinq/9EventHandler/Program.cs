
//5° estanciar a classe que cria o evento
Pedido pedido = new();

//6° assinar os metodos para o evento
pedido.OnCriarPedido += Email.Send;
pedido.OnCriarPedido += Sms.Send;


//7° chama o metodo que vai disparar o evento para os assinantes
pedido.CriarPedido();

Console.ReadKey();

////1° cria o delegate
//delegate void PedidoEventHandler();


//2° cria a classe que vai criar o evento
class Pedido
{

    //3° cria o evento(agr usando um delegate pré definido que vai conter um evento que não possui dados nenhum)
    public event EventHandler? OnCriarPedido;

    //4° cria o metodo que vai dispara o evento
    public void CriarPedido()
    {
        Console.WriteLine("Criando pedido");

        if (OnCriarPedido != null)
        {
            //esse delegate precisa do argumento que é o objeto que se refere a instancia da classe que cria o evento
            // e o argumento que não vai possuir dados nenhum, porem é o mesmo usado para o que possui dados 
            OnCriarPedido(this/*CriarPedidos pedidos = new();*/, EventArgs.Empty);
        }

    }
}





//aqui são os assinantes

class Sms
{
    public static void Send(object? sender, EventArgs e)
    {
        Console.WriteLine("Enviando sms");
    }
}

class Email
{
    public static void Send(object? sender, EventArgs e)
    {
        Console.WriteLine("Enviando email");
    }
}