namespace exercicio_classes4
{
    class ConversorDeMoeda
    {
        public static double Iof = 6.0;
        public static double ConversorDolarParaReal(double cotacao, double dolar)
        {
            double total = cotacao * dolar;
            return total + total * Iof / 100.0;
        }
    }
}
