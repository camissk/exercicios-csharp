using System;

namespace exercicio_vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudante[] vect = new Estudante[10];

            Console.Write("Quantos estudantes desejam alugar um quarto? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Aluguel #{i}");
                Console.Write("Insira seu nome: ");
                string nome = Console.ReadLine();
                Console.Write("Insira seu email: ");
                string email = Console.ReadLine();
                Console.Write("Insira o numero do quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                vect[quarto] = new Estudante(nome, email);
            }

            Console.WriteLine();
            Console.WriteLine("Quartos alugados: ");

            for (int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(i + ":" + vect[i]);
                }
            }
        }
    }
}
