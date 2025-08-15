using System;
using Console_projects;

ContaCorrente contaCorrente = new ContaCorrente(0.05m); // 5% interest rate
contaCorrente.Creditar(100); // Deposit 100
contaCorrente.ObterSaldo(); // Should return 105 after interest

ContaPoupanca contaPoupanca = new ContaPoupanca();
contaPoupanca.Creditar(200); // Deposit 200
contaPoupanca.CalcularRendimento(); // Apply interest