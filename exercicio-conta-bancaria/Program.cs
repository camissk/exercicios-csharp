using System;
using System.Globalization;

namespace exercicio_construtores_sobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria cb; 

            Console.WriteLine("Entre com os dados da conta: ");
            Console.Write("Numero da conta: ");
            int conta = int.Parse(Console.ReadLine());
            Console.Write("Titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá deposito inicial (s/n)? ");
            char dep = char.Parse(Console.ReadLine());
            if (dep == 's')
            {
                Console.Write("Entre com o valor de depósito: ");
                double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                cb = new ContaBancaria(conta, titular, valor);
            }
            else
            {
                cb = new ContaBancaria(conta, titular);
            }

            Console.WriteLine();
            Console.WriteLine(cb);
            Console.WriteLine();

            Console.Write("Entre um valor para depósito: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

           cb.Deposito(deposito);

            Console.WriteLine("Dados atualizados: " + cb);

            Console.WriteLine();

            Console.Write("Entre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            cb.Saque(saque);

            Console.Write("Dados atualizados: " + cb);
        }
    }
}
