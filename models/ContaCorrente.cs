namespace Console_projects;

public class ContaCorrente : Conta
{
    private decimal taxaJuros;

    public ContaCorrente(decimal taxaJuros, int numeroConta) : base(numeroConta) // Criando o construtor e devolvendo o número da conta a classe base
    
    {
        this.taxaJuros = taxaJuros;
    }

    public override void Creditar(decimal valor)
    {
        saldo += valor;
        saldo += saldo * taxaJuros;
    }
}