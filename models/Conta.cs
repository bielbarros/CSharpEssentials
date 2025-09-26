namespace Console_projects;



public abstract class Conta
{
    protected decimal saldo;
    private int numeroConta;

    public Conta(int numeroConta)
    {
        this.numeroConta = numeroConta;
    }

    public abstract void Creditar(decimal valor);

    public void ObterSaldo()
    {
        Console.WriteLine($"Seu saldo é: {saldo}");
    }

}
