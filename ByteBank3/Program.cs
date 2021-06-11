using System;

namespace ByteBank3
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();

            conta.DefinirSaldo(-10);
            Console.WriteLine(conta.ObterSaldo());
        }
    }
}
