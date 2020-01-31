using System.Globalization;

namespace exercicio_construtores_sobrecarga
{
    class ContaBancaria
    {
        double taxa = 5.00;

        public int Conta { get; private set; }
        public string Titular { get; set; }
        public double SaldoInicial { get; set; }

        public ContaBancaria(int conta, string titular)
        {
            Conta = conta;
            Titular = titular;
        }

        public ContaBancaria(int conta, string titular, double saldoInicial) : this (conta, titular)
        {
            SaldoInicial = saldoInicial;
        }

        public void Saque(double quantia)
        {
            SaldoInicial = (SaldoInicial - quantia) - taxa;
        }

        public void Deposito(double quantia)
        {
            SaldoInicial = SaldoInicial + quantia;
        }

        public override string ToString()
        {
            return "Conta "
                + Conta
                + ", Titular: "
                + Titular
                + ", Saldo: R$"
                + SaldoInicial.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
