namespace models.Curso;
using System;
using System.Collections.Generic;
using models.Pessoa;

public class Curso
{
    public string Nome { get; set; }
    public List<Pessoa> Alunos { get; set; }

    public void AdicionarAluno(Pessoa aluno)
    {
        Alunos.Add(aluno);
        Console.WriteLine($"Aluno {aluno.NomeCompleto} adicionado com sucesso ao curso {Nome}.");
    }


    public int ListarAlunosMatriculados()
    {
        int quantidade = Alunos.Count;
        Console.WriteLine($"Quantidade de alunos matriculados: {quantidade}");
        if (quantidade == 0)
        {
            Console.WriteLine("Nenhum aluno matriculado.");
            return 0;
        }
        return quantidade;
    }


    public void RemoverAluno(Pessoa aluno)
    {
        if (Alunos.Contains(aluno))
        {
            Alunos.Remove(aluno);
            Console.WriteLine($"Aluno {aluno.NomeCompleto} removido com sucesso.");
        }
        else
        {
            Console.WriteLine($"Aluno {aluno.NomeCompleto} não encontrado.");
        }
    }


    public void ListarAlunos()
    {
        Console.WriteLine("Lista de Alunos:");
        foreach (var aluno in Alunos)
        {
            Console.WriteLine($"Nome: {aluno.NomeCompleto}, Idade: {aluno.Idade}");
        }
    }


}
