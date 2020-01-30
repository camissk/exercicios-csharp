using System;
using System.Globalization;

namespace exercicio_classes1
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario func1 = new Funcionario();
            Funcionario func2 = new Funcionario();

            Console.WriteLine("Digite os dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            func1.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            func1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();

            Console.WriteLine("Digite os dados do segundo funcionário: ");
            Console.Write("Nome: ");
            func2.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            func2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (func1.Salario + func2.Salario) / 2.0;

            Console.WriteLine("A média de salário é: R$" + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
