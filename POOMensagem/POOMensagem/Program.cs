using System;

namespace POOMensagem
{
    class Program
    {
        static void Main(string[] args)
        {
            Mensagem msg1 = new Mensagem();
            msg1.TextoMensagem = "Hello World";
            Console.WriteLine(msg1.TextoMensagem);

            Mensagem msg2 = new Mensagem();
            msg2.TextoMensagem = "Segundo objeto";
            Console.WriteLine(msg2.TextoMensagem);
        }
    }
}
