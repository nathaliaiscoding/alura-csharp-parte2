namespace ByteBank4 {
public class ContaCorrente
{
   public static int TotalDeContasCriadas { get; private set; }
   
    public Cliente Titular { get; set; }

    private int _agencia;
    public int Agencia { 
        get {
            return _agencia;
        }
         set {
             if(value <= 0) {
                 return;
             }
             _agencia = value;
         }
          }
    public int Conta { get; set; }
    private double _saldo = 100; // se não for atribuído nenhum valor, ele atribui 0 (zero)

    public double Saldo {
            get {
                    return _saldo;
                }
                set {
                    if (value < 0) {
                        return;
                    }
                    _saldo = value;
                }
    }
    public bool Sacar(double valor)
    {
        if (_saldo < valor)
        {
            return false;
        }
  
        _saldo -= valor;
        return true;
  
    }

    public void Depositar(double valor)
    {
        _saldo += valor;
    }

    public bool Transferir(double valor, ContaCorrente contaDestino)
    {

        if (_saldo < valor)
        {
            return false;
        }

        _saldo -= valor;
        contaDestino.Saldo += valor;
        return true;
    }
   
   // constructor
   public ContaCorrente(int agencia, int conta) {
       _agencia = agencia;
       Conta = conta;

       TotalDeContasCriadas++;
   }
}
}