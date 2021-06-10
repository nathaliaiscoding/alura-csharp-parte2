using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaGabriela = new ContaCorrente();

            contaGabriela.titular = "Gabriela";
            contaGabriela.agencia = 863;
            contaGabriela.conta = 863452;
            contaGabriela.saldo = 100;

            Console.WriteLine(contaGabriela.titular);
            Console.WriteLine("Agência: " + contaGabriela.agencia);
            Console.WriteLine("Conta: " + contaGabriela.conta);
            Console.WriteLine("Saldo: " + contaGabriela.saldo);

            contaGabriela.saldo += 200;
            Console.WriteLine("Saldo em 12/6/2021: " + contaGabriela.saldo);

            Console.ReadLine();
        }
    }
}
