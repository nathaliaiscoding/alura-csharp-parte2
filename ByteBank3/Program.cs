using System;

namespace ByteBank3
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();

            conta.Saldo = -10;
            Console.WriteLine(conta.Saldo);
        }
    }
}
