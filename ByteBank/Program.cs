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

            ContaCorrente contaBruna = new ContaCorrente();
            contaBruna.titular = "Bruna";

            Console.WriteLine(contaGabriela.titular);
            Console.WriteLine("Agência: " + contaGabriela.agencia);
            Console.WriteLine("Conta: " + contaGabriela.conta);
            Console.WriteLine("Saldo: " + contaGabriela.saldo);

            contaGabriela.saldo += 200;
            Console.WriteLine("Saldo em 12/6/2021: " + contaGabriela.saldo);

            contaGabriela.Sacar(50);
            Console.WriteLine("Saldo após o saque " + contaGabriela.saldo);

            contaGabriela.Depositar(500);
            Console.WriteLine("Seu saldo após o depósito é " + contaGabriela.saldo);

            contaGabriela.Transferir(300, contaBruna);
            Console.WriteLine("Gabriela transferiu R$300 para Bruna com sucesso!");
            Console.WriteLine("Saldo de Gabriela: R$" + contaGabriela.saldo);
            Console.WriteLine("Saldo de Bruna: R$" + contaBruna.saldo);

            Console.ReadLine();
        }
    }
}
