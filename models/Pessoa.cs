using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace models.Pessoa
{

    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string CPF { get; set; }

        public Pessoa(string nome, int idade, string cpf)
        {
            Nome = nome;
            Idade = idade;
            CPF = cpf;

        }

        public void InserirDados()
        {
            
        }


        public void ValidarNome()
        {
            if (string.IsNullOrEmpty(Nome))
            {
                Console.WriteLine("Nome inválido.");
                return;
            }

            Console.WriteLine("Nome válido.");
        }




        public void ValidarIdade()
        {
            if (Idade < 0)
            {
                Console.WriteLine("Idade inválida.");
                return;
            }

            Console.WriteLine("Idade válida.");
        }



        public void ValidarCPF()
        {
            if (string.IsNullOrEmpty(CPF) || CPF.Length != 11)
            {
                Console.WriteLine("CPF inválido.");
                return;
            }

            // Lógica de validação do CPF
            Console.WriteLine("CPF válido.");
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Idade: {Idade}");
            Console.WriteLine($"CPF: {CPF}");
            Console.WriteLine("Dados cadastrados com sucesso.");
        }


    }

}