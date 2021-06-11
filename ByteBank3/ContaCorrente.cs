namespace ByteBank3 {
public class ContaCorrente
{
    public Cliente titular;
    public int agencia;
    public int conta;
    private double saldo = 100; // se não for atribuído nenhum valor, ele atribui 0 (zero)


    public bool Sacar(double valor)
    {
        if (this.saldo < valor)
        {
            return false;
        }
  
        this.saldo -= valor;
        return true;
  
    }

    public void Depositar(double valor)
    {
        this.saldo += valor;
    }

    public bool Transferir(double valor, ContaCorrente contaDestino)
    {

        if (this.saldo < valor)
        {
            return false;
        }

        this.saldo -= valor;
        contaDestino.saldo += valor;
        return true;
    }

    public double ObterSaldo() {
            return this.saldo;
        }

    public void DefinirSaldo(double saldo) {
        if (saldo < 0) {
                return;
            }
            this.saldo = saldo;
        }
}
}