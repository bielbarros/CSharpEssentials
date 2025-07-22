# Documentação: CSharpEssentials.

## Objetivo
Este projeto é uma documentação completa e progressiva da linguagem C#, abrangendo desde conceitos fundamentais até técnicas avançadas de programação orientada a objetos. A documentação serve como um guia de referência para desenvolvedores que estão migrando de outras linguagens (assim como eu) para o ecossistema .NET.

### Escopo da Documentação
```
** Nível Básico:**
- Sintaxe e Tipos de Dados em C#
- Tipos de Operadores em C#
- Operadores Aritméticos em C#
- Estruturas de Repetição em C#
- Organização de um Programa C#
- Array e Listas em C#
- Comentários e Boas Práticas em C#
```

```
** Nível Intermediário:**
- Propriedades, Métodos e Construtores com C#
- Manipulando Valores com C#
- Exceções e Coleções com C#
- Introdução, Abstração e Encapsulamento com C#
- Herança e Polimorfismo com C#
- Classes Abstratas e Interfaces com C#

```

```
** Nível Avançado:**
- Criando Sistemas com POO em C#
- Controle e Análise de Transações com POO
- Introdução às APIs com C#
- Padrões de Projeto
- Testes Unitários
- Performance e Otimização

```
### Características do Projeto
- **Exemplos Práticos**: Cada conceito é demonstrado com código funcional
- **Boas Práticas**: Inclui padrões recomendados e melhores práticas
- **Migração Java → C#**: Foco especial em diferenças e similaridades
- **Projetos Completos**: Sistemas funcionais como estacionamento, celular, etc.
- **Documentação Progressiva**: Do básico ao avançado de forma estruturada

---

##  Índice
1. [Conceitos Básicos](#conceitos-básicos)
2. [Estrutura de Classes](#estrutura-de-classes)
3. [Exemplo Prático: Sistema de Biblioteca](#exemplo-prático-sistema-de-biblioteca)
4. [Implementação Completa](#implementação-completa)
5. [Boas Práticas](#boas-práticas)

---

##  Conceitos Básicos

### O que é uma Classe?
Uma **classe** é um modelo/template que define:
- **Propriedades** (características)
- **Métodos** (ações/comportamentos)
- **Construtores** (inicialização)

### Estrutura Básica:
```csharp
public class NomeDaClasse
{
    // Propriedades (características)
    public string Nome { get; set; }
    
    // Construtor (inicialização)
    public NomeDaClasse()
    {
        // código de inicialização
    }
    
    // Métodos (ações)
    public void Metodo()
    {
        // código do método
    }
}
```

---

##  Estrutura de Classes

### 1. **Propriedades**
```csharp
// Propriedade com get e set automático
public string Nome { get; set; }

// Propriedade somente leitura
public string Id { get; }

// Propriedade com lógica personalizada
private string _email;
public string Email 
{ 
    get { return _email; }
    set { _email = value.ToLower(); }
}
```

### 2. **Construtores**
```csharp
// Construtor padrão
public Livro()
{
    Id = Guid.NewGuid().ToString();
}

// Construtor com parâmetros
public Livro(string titulo, string autor)
{
    Titulo = titulo;
    Autor = autor;
    Id = Guid.NewGuid().ToString();
}
```

### 3. **Métodos**
```csharp
// Método simples
public void ExibirInformacoes()
{
    Console.WriteLine($"Título: {Titulo}");
    Console.WriteLine($"Autor: {Autor}");
}

// Método com retorno
public bool EstaDisponivel()
{
    return !EstaEmprestado;
}

// Método com parâmetros
public void Emprestar(string nomeUsuario)
{
    if (EstaDisponivel())
    {
        EstaEmprestado = true;
        UsuarioEmprestimo = nomeUsuario;
        DataEmprestimo = DateTime.Now;
    }
}
```

---

##  Exemplo Prático: Sistema de Biblioteca

### Estrutura do Sistema:
```
📁 Sistema de Biblioteca
├── 📄 Livro.cs (Classe Livro)
├── 📄 Usuario.cs (Classe Usuário)
├── 📄 Biblioteca.cs (Classe Biblioteca)
└── 📄 Program.cs (Programa principal)
```

### 1. Classe Livro
```csharp
public class Livro
{
    // Propriedades
    public string Id { get; }
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int AnoPublicacao { get; set; }
    public bool EstaEmprestado { get; set; }
    public string? UsuarioEmprestimo { get; set; }
    public DateTime? DataEmprestimo { get; set; }

    // Construtor
    public Livro(string titulo, string autor, int anoPublicacao)
    {
        Id = Guid.NewGuid().ToString();
        Titulo = titulo;
        Autor = autor;
        AnoPublicacao = anoPublicacao;
        EstaEmprestado = false;
    }

    // Métodos
    public void Emprestar(string nomeUsuario)
    {
        if (!EstaEmprestado)
        {
            EstaEmprestado = true;
            UsuarioEmprestimo = nomeUsuario;
            DataEmprestimo = DateTime.Now;
            Console.WriteLine($"Livro '{Titulo}' emprestado para {nomeUsuario}");
        }
        else
        {
            Console.WriteLine($"Livro '{Titulo}' já está emprestado para {UsuarioEmprestimo}");
        }
    }

    public void Devolver()
    {
        if (EstaEmprestado)
        {
            EstaEmprestado = false;
            UsuarioEmprestimo = null;
            DataEmprestimo = null;
            Console.WriteLine($"Livro '{Titulo}' foi devolvido");
        }
        else
        {
            Console.WriteLine($"Livro '{Titulo}' não estava emprestado");
        }
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Título: {Titulo}");
        Console.WriteLine($"Autor: {Autor}");
        Console.WriteLine($"Ano: {AnoPublicacao}");
        Console.WriteLine($"Status: {(EstaEmprestado ? "Emprestado" : "Disponível")}");
        
        if (EstaEmprestado)
        {
            Console.WriteLine($"Emprestado para: {UsuarioEmprestimo}");
            Console.WriteLine($"Data do empréstimo: {DataEmprestimo}");
        }
        Console.WriteLine("---");
    }
}
```

### 2. Classe Usuario
```csharp
public class Usuario
{
    // Propriedades
    public string Id { get; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public List<Livro> LivrosEmprestados { get; set; }

    // Construtor
    public Usuario(string nome, string email)
    {
        Id = Guid.NewGuid().ToString();
        Nome = nome;
        Email = email;
        LivrosEmprestados = new List<Livro>();
    }

    // Métodos
    public void EmprestarLivro(Livro livro)
    {
        livro.Emprestar(Nome);
        LivrosEmprestados.Add(livro);
    }

    public void DevolverLivro(Livro livro)
    {
        livro.Devolver();
        LivrosEmprestados.Remove(livro);
    }

    public void ExibirLivrosEmprestados()
    {
        Console.WriteLine($"\nLivros emprestados para {Nome}:");
        if (LivrosEmprestados.Count == 0)
        {
            Console.WriteLine("Nenhum livro emprestado");
        }
        else
        {
            foreach (var livro in LivrosEmprestados)
            {
                Console.WriteLine($"- {livro.Titulo} (por {livro.Autor})");
            }
        }
    }
}
```

### 3. Classe Biblioteca
```csharp
public class Biblioteca
{
    // Propriedades
    public string Nome { get; set; }
    public List<Livro> Livros { get; set; }
    public List<Usuario> Usuarios { get; set; }

    // Construtor
    public Biblioteca(string nome)
    {
        Nome = nome;
        Livros = new List<Livro>();
        Usuarios = new List<Usuario>();
    }

    // Métodos
    public void AdicionarLivro(Livro livro)
    {
        Livros.Add(livro);
        Console.WriteLine($"Livro '{livro.Titulo}' adicionado à biblioteca");
    }

    public void AdicionarUsuario(Usuario usuario)
    {
        Usuarios.Add(usuario);
        Console.WriteLine($"Usuário '{usuario.Nome}' cadastrado");
    }

    public Livro? BuscarLivroPorTitulo(string titulo)
    {
        return Livros.FirstOrDefault(l => l.Titulo.ToLower().Contains(titulo.ToLower()));
    }

    public Usuario? BuscarUsuarioPorNome(string nome)
    {
        return Usuarios.FirstOrDefault(u => u.Nome.ToLower().Contains(nome.ToLower()));
    }

    public void ListarTodosLivros()
    {
        Console.WriteLine($"\nLivros na biblioteca '{Nome}':");
        if (Livros.Count == 0)
        {
            Console.WriteLine("Nenhum livro cadastrado");
        }
        else
        {
            foreach (var livro in Livros)
            {
                livro.ExibirInformacoes();
            }
        }
    }

    public void ListarTodosUsuarios()
    {
        Console.WriteLine($"\nUsuários cadastrados na biblioteca '{Nome}':");
        if (Usuarios.Count == 0)
        {
            Console.WriteLine("Nenhum usuário cadastrado");
        }
        else
        {
            foreach (var usuario in Usuarios)
            {
                Console.WriteLine($"- {usuario.Nome} ({usuario.Email})");
            }
        }
    }
}
```

---

##  Implementação Completa

### Program.cs
```csharp
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== SISTEMA DE BIBLIOTECA ===\n");

        // Criar biblioteca
        Biblioteca biblioteca = new Biblioteca("Biblioteca Central");

        // Criar livros
        Livro livro1 = new Livro("O Senhor dos Anéis", "J.R.R. Tolkien", 1954);
        Livro livro2 = new Livro("1984", "George Orwell", 1949);
        Livro livro3 = new Livro("Dom Casmurro", "Machado de Assis", 1899);

        // Adicionar livros à biblioteca
        biblioteca.AdicionarLivro(livro1);
        biblioteca.AdicionarLivro(livro2);
        biblioteca.AdicionarLivro(livro3);

        // Criar usuários
        Usuario usuario1 = new Usuario("João Silva", "joao@email.com");
        Usuario usuario2 = new Usuario("Maria Santos", "maria@email.com");

        // Adicionar usuários à biblioteca
        biblioteca.AdicionarUsuario(usuario1);
        biblioteca.AdicionarUsuario(usuario2);

        // Demonstrar funcionalidades
        Console.WriteLine("\n=== DEMONSTRAÇÃO DAS FUNCIONALIDADES ===");

        // Listar todos os livros
        biblioteca.ListarTodosLivros();

        // Emprestar livros
        usuario1.EmprestarLivro(livro1);
        usuario2.EmprestarLivro(livro2);

        // Listar livros emprestados
        usuario1.ExibirLivrosEmprestados();
        usuario2.ExibirLivrosEmprestados();

        // Devolver livros
        usuario1.DevolverLivro(livro1);

        // Buscar livro
        Livro? livroEncontrado = biblioteca.BuscarLivroPorTitulo("1984");
        if (livroEncontrado != null)
        {
            Console.WriteLine($"\nLivro encontrado: {livroEncontrado.Titulo}");
        }

        Console.WriteLine("\n=== FIM DA DEMONSTRAÇÃO ===");
    }
}
```

---

## Boas Práticas

### 1. **Nomenclatura**
- ✅ Use PascalCase para nomes de classes: `Livro`, `Biblioteca`
- ✅ Use PascalCase para propriedades: `Titulo`, `Autor`
- ✅ Use PascalCase para métodos: `EmprestarLivro()`, `DevolverLivro()`

### 2. **Organização**
- ✅ Separe cada classe em um arquivo diferente
- ✅ Use namespaces para organizar classes relacionadas
- ✅ Mantenha métodos relacionados juntos

### 3. **Encapsulamento**
- ✅ Use `public` para métodos que devem ser acessados externamente
- ✅ Use `private` para métodos internos da classe
- ✅ Use propriedades com `get` e `set` para controle de acesso

### 4. **Construtores**
- ✅ Sempre inicialize propriedades importantes no construtor
- ✅ Use construtores com parâmetros para inicialização obrigatória
- ✅ Considere usar construtores sobrecarregados

### 5. **Métodos**
- ✅ Mantenha métodos pequenos e focados em uma tarefa
- ✅ Use nomes descritivos para métodos
- ✅ Retorne valores quando apropriado
- ✅ Trate erros e casos especiais

---

## 📝 Conclusão

Esta documentação demonstra os conceitos fundamentais de criação de classes em C# usando vários exemplos com sistemas práticos. Os mesmos princípios podem ser aplicados a diversos tipos de sistemas, adaptando as classes e funcionalidades conforme necessário.

