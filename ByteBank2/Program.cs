using System;

namespace ByteBank2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente nathalia = new Cliente();
            nathalia.nome = "Nathalia";
            nathalia.cpf = "123.787.856-09";
            nathalia.profissao = "Desenvolvedora";
            nathalia.endereco.cep = "22.222-22";

            ContaCorrente conta = new ContaCorrente();
            conta.titular = nathalia;
            conta.agencia = 0001;
            conta.conta = 234685;
            conta.saldo = 100;
         
            Console.WriteLine(conta.titular.nome);
            Console.WriteLine(nathalia.endereco.cep);
            Console.ReadLine();
        }
    }
}
