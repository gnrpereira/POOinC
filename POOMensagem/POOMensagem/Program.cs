namespace POOMensagem
{
    class Program
    {
        static void Main(string[] args)
        {
            Mensagem msg1 = new Mensagem();
            msg1.TextoMensagem = "Hello World";
            msg1.ExibirMensagem();

            Mensagem msg2 = new Mensagem();
            msg1.TextoMensagem = "Segundo objeto";
            msg1.ExibirMensagem();
        }
    }
}
