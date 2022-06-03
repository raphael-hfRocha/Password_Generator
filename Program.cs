using System;

namespace security
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia, mes, ano;
            string nome;
            DateTime dataDeNascimento = DateTime.Now;

            Console.WriteLine("informe seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Seja bem vindo " + nome);
            Console.WriteLine("Informe seu dia de nascimento:");
            dia = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe seu mês de nascimento:");
            mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe seu ano de nascimento:");
            ano = int.Parse(Console.ReadLine());

            dataDeNascimento = new DateTime(ano, mes, dia);
            var idade = (int)(DateTime.Today.Subtract(dataDeNascimento).TotalDays / 365);
            Console.WriteLine("Sua idade é " + idade);

            if (idade >= 18)
            {
                Console.WriteLine($"Sua senha é {idade}@{nome}");
            }

            else
            {
                Console.WriteLine($"Sua senha é {nome}@{idade}");
            }
        }
    }
}
