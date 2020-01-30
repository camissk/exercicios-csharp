using System;

namespace exercicio_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.WriteLine("Digite os dados da primeira pessoa: ");
            Console.Write("Digite seu nome: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Digite sua idade: ");
            p1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Digite os dados da segunda pessoa: ");
            Console.Write("Digite seu nome: ");
            p2.Nome = Console.ReadLine();
            Console.Write("Digite sua idade: ");
            p2.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine();

            if (p1.Idade > p2.Idade)
            {
                Console.WriteLine(p1.Nome + " é a pessoa mais velha!");
            }
            else
            {
                Console.WriteLine(p2.Nome + " é a pessoa mais velha!");
            }
        }
    }
}
