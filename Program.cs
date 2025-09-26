using System;
using Console_projects;

ContaCorrente contaCorrente = new ContaCorrente(0.05m, 111); // 5% interest rate
contaCorrente.Creditar(100); // Deposit 100
contaCorrente.ObterSaldo(); // Should return 105 after interest

ContaPoupanca contaPoupanca = new ContaPoupanca(12345); // Provide a valid account number
contaPoupanca.Creditar(200); // Deposit 200
contaPoupanca.CalcularRendimento(); // Apply interest