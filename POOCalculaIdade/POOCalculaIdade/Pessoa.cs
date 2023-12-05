using System;

namespace POOCalculaIdade
{
    public class Pessoa
    {
        private int anoNascimento;

        public int AnoNascimento
        {
            get { return anoNascimento; }
            set { anoNascimento = value; }
        }

        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value.ToUpper(); }
        }

        //Vamos melhorar
        private int idade;

        public int Idade
        {
            get
            {
                this.CalcularIdade();
                return idade;
            }
        }


        public void ExibirDados()
        {
            Console.WriteLine();
            Console.WriteLine($"Nome: {this.Nome}");
            Console.WriteLine($"Ano de nascimento: {this.AnoNascimento}");
            this.CalcularIdade();
            Console.WriteLine($"Idade: {this.Idade} anos");
        }

        private void CalcularIdade()
        {
            DateTime data = DateTime.Now;
            int ano = data.Year;
            this.idade = ano - this.AnoNascimento;
        }

    }
}
