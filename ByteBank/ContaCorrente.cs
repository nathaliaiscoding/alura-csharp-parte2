public class ContaCorrente
{
    public string titular;
    public int agencia;
    public int conta;
    public double saldo = 100; // se não for atribuído nenhum valor, ele atribui 0 (zero)


    public bool Sacar(double valor)
    {
        if (this.saldo < valor)
        {
            return false;
        }
        else
        {
            this.saldo -= valor;
            return true;
        }
    }
}