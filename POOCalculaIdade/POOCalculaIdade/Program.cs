using System;

namespace POOCalculaIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t***** Calcula idade *****");

            Pessoa p = new Pessoa();
            Console.Write("Nome da pessoa: ");
            p.Nome = Console.ReadLine();
            Console.Write("Ano de nascimento: ");
            p.AnoNascimento = Convert.ToInt32(Console.ReadLine());

            p.ExibirDados();
        }
    }
}
