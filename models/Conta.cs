namespace Console_projects;

public class Conta
{
    private double Saldo { get; set; }

    public Conta(double saldoInicial)
    {
        Saldo = saldoInicial;
    }

    public void Depositar(double valor)
    {
        Saldo += valor;
    }

    public bool Sacar(double valor)
    {
        if (valor > Saldo)
        {
            return false;
        }
        Saldo -= valor;
        return true;
    }

    public double ObterSaldo()
    {
        return Saldo;
    }
}
