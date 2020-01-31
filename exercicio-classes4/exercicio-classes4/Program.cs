using System;
using System.Globalization;

namespace exercicio_classes4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual a cotação do dolar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dolares voce vai comprar? ");
            double dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double conversor = ConversorDeMoeda.ConversorDolarParaReal(cotacao, dolar);
            
            Console.WriteLine("Valor a ser pago em reais: " + conversor.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
