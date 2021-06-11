using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank4
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaNathalia = new ContaCorrente(856, 88909);
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
            ContaCorrente contaThalita = new ContaCorrente(856, 88910);
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
            ContaCorrente contaMarie = new ContaCorrente(856, 88911);
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            Console.WriteLine(contaNathalia.Agencia);
            Console.WriteLine(contaNathalia.Conta);
            Console.WriteLine(contaThalita.Agencia);        
            Console.WriteLine(contaThalita.Conta);
            Console.WriteLine(contaMarie.Agencia);
            Console.WriteLine(contaMarie.Conta);
        }
    }
}
