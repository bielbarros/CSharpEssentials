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

        public Pessoa(string nome, int idade, string cpf)
        {
            Nome = nome;
            Idade = idade;
            CPF = cpf;

        }

        public void ValidarDados()
        {
            if (string.IsNullOrEmpty(Nome) || Idade < 0 || string.IsNullOrEmpty(CPF) || CPF.Length != 11)
            {
                throw new InvalidOperationException("Dados inválidos.");
            }
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