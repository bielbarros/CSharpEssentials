namespace Console_projects;

public class ContaPoupanca : Conta
{
    private decimal saldoLiquido;

    public override void Creditar(decimal valor)
    {
        saldoLiquido += valor;
    }

    public void CalcularRendimento()
    {
        saldoLiquido += saldoLiquido * 0.05m; // 5% rendimento
        Console.WriteLine($"Saldo após rendimento: {saldoLiquido}");
    }
}
