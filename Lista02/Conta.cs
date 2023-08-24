class Conta
{
    public string NomeTitular { get; }
    public string NumeroAgencia { get; }
    public string NumeroConta { get; }
    private double Saldo { get; set; }

    public Conta(string nomeTitular, string numeroAgencia, string numeroConta, double saldoInicial)
    {
        NomeTitular = nomeTitular;
        NumeroAgencia = numeroAgencia;
        NumeroConta = numeroConta;
        Saldo = saldoInicial;
    }

    public void Depositar(double valor)
    {
        if (valor > 0)
            Saldo += valor;
    }

    public bool Sacar(double valor)
    {
        if (valor > 0 && valor <= Saldo)
        {
            Saldo -= valor;
            return true;
        }
        return false;
    }

    public double ObterSaldo()
    {
        return Saldo;
    }
}