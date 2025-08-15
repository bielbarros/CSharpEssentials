using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace models.Pessoa
{
    public class Pessoa
    {
        private string _nome;
        private string _sobrenome;
        private int _idade;
        private string _cpf;

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Nome não pode ser vazio.");
                }

                _nome = value;
            }
        }

        public string Sobrenome
        {
            get { return _sobrenome; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Sobrenome não pode ser vazio.");
                }

                _sobrenome = value;
            }
        }

        public string NomeCompleto => $"{Nome} {Sobrenome}";

        public int Idade
        {
            get { return _idade; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Idade não pode ser negativa.");
                }
                else if (value > 120)
                {
                    throw new ArgumentException("Idade inválida.");
                }
                else if (value < 18)
                {
                    Console.WriteLine("Aviso: Pessoa menor de idade.");
                }

                _idade = value;
            }
        }

        public string CPF
        {
            get => _cpf; // Usando body expression para simplificar o getter
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length != 11)
                {
                    throw new ArgumentException("CPF inválido.");
                }

                _cpf = value;
            }
        }

        public Pessoa() // Construtor vazio
        {
            
        }


        public Pessoa(string nome, string sobrenome, int idade, string cpf)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Idade = idade;
            CPF = cpf;

        }


        public void ValidarDados()
        {
            if (string.IsNullOrEmpty(Nome) || Idade < 0 || string.IsNullOrEmpty(CPF) || CPF.Length != 11)
            {
                throw new InvalidOperationException("Dados inválidos.");
            }

            Console.WriteLine("Confirme com um SIM ou NÃO se os dados estão corretos:");
            string resposta = Console.ReadLine().ToUpperInvariant();

            if (resposta == "SIM")
            {
                Console.WriteLine("Dados confirmados.");
                Console.WriteLine("Dados cadastrados com sucesso.");
            }
            else
            {
                Console.WriteLine("Dados não confirmados.");
            }
        }


        public void ExibirInformacoes()
        {
            Console.WriteLine($"Nome Completo: {NomeCompleto}");
            Console.WriteLine($"Idade: {Idade}");
            Console.WriteLine($"CPF: {CPF}");
            Console.WriteLine("------------------------------");
        }
    }

}