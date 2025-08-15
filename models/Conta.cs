namespace Console_projects;



public abstract class Conta
{
    protected decimal saldo;

    public abstract void Creditar(decimal valor);

    public void ObterSaldo()
    {
        Console.WriteLine($"Seu saldo é: {saldo}");
    }

}
