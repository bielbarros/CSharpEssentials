namespace Console_projects;

public class ContaCorrente : Conta
{
    private decimal taxaJuros;

    public ContaCorrente(decimal taxaJuros)
    {
        this.taxaJuros = taxaJuros;
    }

    public override void Creditar(decimal valor)
    {
        saldo += valor;
        saldo += saldo * taxaJuros;
    }
}