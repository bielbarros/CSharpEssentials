namespace Console_projects;

public class ContaCorrente : Conta
{
    public ContaCorrente(double saldoInicial) : base(saldoInicial)
    {
    }

    public void AplicarJuros(double taxa)
    {
        double juros = ObterSaldo() * taxa;
        Depositar(juros);
    }
}
