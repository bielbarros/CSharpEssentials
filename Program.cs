using System;   
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Text.RegularExpressions;
using System.Globalization;
using models.Estacionamento;
using models.Pessoa;
using models.Curso;

/*
Console.WriteLine("Hello, World!");
Console.WriteLine("");
*/

/*
Cast - Casting (Conversões)

int a = Convert.ToInt32("123"); // Convert.ToInt32 converte uma string para um inteiro 
Console.WriteLine(a);

int b = int.Parse("5"); // int.Parse converte uma string para um inteiro, porém o Parse não aceita valores nulos
// int.Parse("5") é mais rápido que Convert.ToInt32("5")
Console.WriteLine(b);


int inteiro = 10;
string c = inteiro.ToString(); // ToString converte um inteiro para uma string
Console.WriteLine(c);


// Conversões não necessárias

int d = 5;
long e = d;

Console.WriteLine(e);


// Conversões seguras:

string f = "123";

int g = 0;

if (int.TryParse(f, out g)) // int.TryParse tenta converter uma string para um inteiro, se não conseguir retorna false
{
    Console.WriteLine(g);
    Console.WriteLine("Conversão bem-sucedida: " + g);
}
else
{
    Console.WriteLine("Conversão falhou");
}
*/

/*
CONDICIONAIS


int quantidade = 0;

if (quantidade > 0) // if serve para verificar uma condição
{
    Console.WriteLine("Quantidade é maior que zero");
}
else if (quantidade == 0) // else if serve para verificar uma condição adicional 
{
    Console.WriteLine("Quantidade é igual a zero");
}
else // else serve para verificar se nenhuma das condições anteriores foi atendida
{
    Console.WriteLine("Quantidade é menor que zero");
}


// Operadores lógicos
bool condicao1 = false;
bool condicao2 = false;


if (condicao1 && condicao2) // E lógico
{
    Console.WriteLine("Ambas as condições são verdadeiras");
}
else if (condicao1 || condicao2) // OU lógico
{
    Console.WriteLine("Pelo menos uma condição é verdadeira");
}
else
{
    Console.WriteLine("Nenhuma condição é verdadeira");
}
*/

/*
Switch Case 


int numero = 2;
switch (numero) // switch serve para verificar o valor de uma variável
{
    case 1:
        Console.WriteLine("O número é 1");
        break; // break serve para sair do switch
    case 2:
        Console.WriteLine("O número é 2");
        break;
    case 3:
        Console.WriteLine("O número é 3");
        break;
    default: // default serve para verificar se nenhum dos casos anteriores foi atendido
        Console.WriteLine("O número não é 1, 2 ou 3");
        break;
}
*/

/*
// Operadores de comparação
int x = 10;
int y = 20;

// && é o operador lógico E, que verifica se ambas as condições são verdadeiras
// || é o operador lógico OU, que verifica se pelo menos uma das condições é verdadeira, conhecido como pipe. 


if (x == y) // Igualdade
{
    Console.WriteLine("x é igual a y");
}
else if (x != y) // Diferença
{
    Console.WriteLine("x é diferente de y");
}
else if (x < y) // Menor que
{
    Console.WriteLine("x é menor que y");
}
else if (x > y) // Maior que
{
    Console.WriteLine("x é maior que y");
}
else if (x <= y) // Menor ou igual a
{
    Console.WriteLine("x é menor ou igual a y");
}
else if (x >= y) // Maior ou igual a
{
    Console.WriteLine("x é maior ou igual a y");
}
else
{
    Console.WriteLine("Nenhuma das condições foi atendida");
}
*/



/*
// Operador NOT 
bool estaTarde = true; // O operador NOT inverte o valor da variável, se for true, passa a ser false e vice-versa
// O operador NOT é representado pelo símbolo de exclamação (!)


if (!estaTarde) // O operador NOT inverte o valor da variável, se for
{
    Console.WriteLine("Ainda não é tarde");
}
else
{
    Console.WriteLine("Já é tarde");
}   
*/



/*
// Operadores ternários
int idade = 18;
string resultado = (idade >= 18) ? "Maior de idade" : "Menor de idade";
Console.WriteLine(resultado);
// O operador ternário é uma forma concisa de escrever uma condição if-else
// A sintaxe é: (condição) ? valor_se_verdadeiro : valor_se_falso
*/

/*
// Operadores aritméticos
int num1 = 10;
int num2 = 5;
int soma = num1 + num2; // Soma
int subtracao = num1 - num2; // Subtração   
int multiplicacao = num1 * num2; // Multiplicação
int divisao = num1 / num2; // Divisão
int resto = num1 % num2; // Módulo (resto da divisão)
int potencia = (int)Math.Pow(num1, num2); // Potência (num1 elevado a num2)
Console.WriteLine($"Soma: {soma}");
Console.WriteLine($"Subtração: {subtracao}");
Console.WriteLine($"Multiplicação: {multiplicacao}");
Console.WriteLine($"Divisão: {divisao}");
Console.WriteLine($"Resto: {resto}");
Console.WriteLine($"Potência: {potencia}");


// Incremento e Decremento
num1++; // Incrementa num1 em 1
num2--; // Decrementa num2 em 1
Console.WriteLine($"Incremento: {num1}");
Console.WriteLine($"Decremento: {num2}");


// Operadores de atribuição
int a = 10;
a += 5; // a = a + 5
Console.WriteLine($"Atribuição com adição: {a}");
a -= 3; // a = a - 3
Console.WriteLine($"Atribuição com subtração: {a}");
a *= 2; // a = a * 2
Console.WriteLine($"Atribuição com multiplicação: {a}");
a /= 4; // a = a / 4
Console.WriteLine($"Atribuição com divisão: {a}");
*/

/*
// Funções trigonométricas
double angulo = 30.0; // Ângulo em graus
double radianos = angulo * (Math.PI / 180); // Converte graus para radianos


public void Seno()
{
    double seno = Math.Sin(radianos);
    Console.WriteLine($"Seno de {angulo} graus: {seno}");
}

public void Coseno()
{
    double coseno = Math.Cos(radianos);
    Console.WriteLine($"Coseno de {angulo} graus: {coseno}");
}

public void Tangente()
{
    double tangente = Math.Tan(radianos);
    Console.WriteLine($"Tangente de {angulo} graus: {tangente}");
}


// Raiz quadrada
public void RaizQuadrada()
{
    double numeroRaiz = 16.0; // Número para calcular a raiz quadrada
    double raizQuadrada = Math.Sqrt(numeroRaiz);
    Console.WriteLine($"Raiz quadrada de {numeroRaiz}: {raizQuadrada}");
}


// Logaritmo
public void Logaritmo()
{
    double numeroLog = 100.0; // Número para calcular o logaritmo
    double logaritmoBase10 = Math.Log10(numeroLog); // Logaritmo na base 10
    double logaritmoNatural = Math.Log(numeroLog); // Logaritmo natural (base e)
    Console.WriteLine($"Logaritmo base 10 de {numeroLog}: {logaritmoBase10}");
    Console.WriteLine($"Logaritmo natural de {numeroLog}: {logaritmoNatural}");
}
*/

/*
// Operadores de repetição:


// For Loop
for (int i = 0; i < 5; i++) // O loop for executa um bloco de código um número específico de vezes
{
    Console.WriteLine($"Iteração {i + 1}");
}

// While Loop
int contador = 0;
while (contador < 5) // O loop while executa um bloco de código enquanto uma condição for verdadeira
{
    Console.WriteLine($"Contador: {contador}");
    contador++;
}


// Do-While Loop
contador = 0;
do
{
    Console.WriteLine($"Contador (do-while): {contador}");
    contador++;
} while (contador < 5);


// Foreach Loop
string[] frutas = { "Maçã", "Banana", "Laranja" };
foreach (string fruta in frutas)
{
    Console.WriteLine($"Fruta: {fruta}");
}
*/

/*
// Menu com While Loop e Switch Case
while (true) // Loop infinito, você pode sair com um comando break
{
    Console.Clear(); // Limpa a tela do console
    Console.WriteLine("Bem-vindo ao Menu!");
    Console.WriteLine("Menu:");
    Console.WriteLine("1. Opção 1");
    Console.WriteLine("2. Opção 2");
    Console.WriteLine("3. Sair");

    string escolha = Console.ReadLine();

    switch (escolha)
    {
        case "1":
            Console.WriteLine("Você escolheu a Opção 1");
            break;
        case "2":
            Console.WriteLine("Você escolheu a Opção 2");
            break;
        case "3":
            Console.WriteLine("Saindo...");
            return; // Sai do programa
        default:
            Console.WriteLine("Opção inválida, tente novamente.");
            break;
    }
}
*/

/*
// Arquivos de projeto.

// .csproj = arquivo de projeto do C# que contém informações sobre o projeto, como dependências, configurações de compilação e outros metadados.
// Ele é usado pelo .NET SDK para compilar e construir o projeto.

// .sln = arquivo de solução do Visual Studio que agrupa um ou mais projetos relacionados. Ele contém informações sobre os projetos incluídos na solução, suas dependências e configurações de build.

// .user = arquivo de usuário do Visual Studio que armazena configurações específicas do usuário, como preferências de layout, configurações de depuração e outras personalizações. Ele é usado para personalizar a experiência do usuário no Visual Studio e não deve ser compartilhado entre diferentes usuários ou ambientes.

// .gitignore = arquivo usado pelo Git para especificar quais arquivos ou diretórios devem ser ignorados pelo controle de versão. Ele é usado para evitar que arquivos temporários, de configuração ou outros arquivos desnecessários sejam rastreados pelo Git.

// .vs = pasta oculta criada pelo Visual Studio que contém informações de configuração e cache do ambiente de desenvolvimento. Ela é usada para melhorar o desempenho do Visual Studio, armazenando informações sobre o estado do projeto, histórico de navegação e outras configurações específicas do usuário.
// .vscode = pasta que contém configurações específicas do Visual Studio Code, como extensões
// e configurações de depuração. Ela é usada para personalizar a experiência do usuário no Visual Studio Code e pode incluir arquivos como settings.json, launch.json e tasks.json.

// .dll = arquivo de biblioteca de vínculo dinâmico (Dynamic Link Library) que contém código compilado que pode ser compartilhado entre diferentes aplicativos. Ele é usado para encapsular funcionalidades reutilizáveis e pode ser referenciado por outros projetos ou aplicativos.
// .exe = arquivo executável que contém o código compilado de um aplicativo. Ele é o arquivo principal que é executado quando o aplicativo é iniciado. O arquivo .exe contém o ponto de entrada do programa e pode ser executado diretamente pelo sistema operacional.
// .pdb = arquivo de banco de dados de programa (Program Database) que contém informações de depuração para um aplicativo. Ele é usado pelo depurador para mapear o código-fonte original para o código compilado, permitindo que os desenvolvedores depurem o aplicativo de forma mais eficaz. O arquivo .pdb contém informações sobre símbolos, variáveis e outros metadados necessários para a depuração.
// .json = arquivo de formato de dados JavaScript Object Notation (JSON) que é usado para armazenar e transmitir dados estruturados. Ele é amplamente utilizado para configuração, troca de dados entre aplicativos e armazenamento de informações em um formato legível por humanos. O JSON é fácil de ler e escrever, e é compatível com muitas linguagens de programação, incluindo C#.
// .config = arquivo de configuração usado para armazenar configurações de aplicativos, como strings de conexão, configurações de depuração e outras opções. Ele é usado pelo .NET Framework e pelo .NET Core para carregar configurações em tempo de execução. O arquivo .config é geralmente um arquivo XML que contém seções específicas para diferentes tipos de configurações, como appSettings, connectionStrings e outras seções personalizadas.
// .xml = arquivo de marcação extensível (XML) que é usado para armazenar dados estruturados em um formato legível por humanos. Ele é amplamente utilizado para configuração, troca de dados entre aplicativos e armazenamento de informações em um formato padronizado. O XML é flexível e pode ser usado para representar uma ampla variedade de estruturas de dados, incluindo hierarquias, listas e outros tipos de dados complexos.
// .cs = arquivo de código-fonte C# que contém definições de classes, métodos e outros elementos do programa. Ele é usado para escrever o código do aplicativo e é compilado pelo compilador C# para gerar o código executável ou a biblioteca de vínculo dinâmico (DLL).
*/

/*
// Array e listas:

// Array é uma coleção de elementos do mesmo tipo, com tamanho fixo
// List é uma coleção de elementos do mesmo tipo, com tamanho dinâmico
// Exemplos:

Console.WriteLine("---------------------------");
Console.WriteLine("Array:");

int[] numerosArray = new int[5]; // Array de inteiros com 5 elementos


// Adicionando dados diretamente pelos índices
numerosArray[0] = 10; // Primeiro elemento
numerosArray[1] = 20; // Segundo elemento
numerosArray[2] = 30; // Terceiro elemento
numerosArray[3] = 40; // Quarto elemento
numerosArray[4] = 50; // Quinto elemento


int[] arrayDobrado = new int[numerosArray.Length * 2];
Array.Copy(numerosArray, arrayDobrado, numerosArray.Length);





for (int contador = 0; contador < numerosArray.Length; contador++)
{
    Console.WriteLine(numerosArray[contador]);
}

Console.WriteLine("---------------------------");

foreach (int valor in numerosArray) 
{
    Console.WriteLine(valor);
}




// Método 1: Inicialização direta
int[] numerosArray1 = { 1, 2, 3, 4, 5 };

// Método 2: Inicialização com new
int[] numerosArray2 = new int[] { 10, 20, 30, 40, 50 };

// Método 3: Inicialização com tamanho e valores
int[] numerosArray3 = new int[5] { 100, 200, 300, 400, 500 };

Console.WriteLine(numerosArray[0]); // Imprime o primeiro elemento do array
Console.WriteLine(numerosArray[1]); // Imprime o segundo elemento do array
Console.WriteLine(numerosArray[2]); // Imprime o terceiro elemento do array
Console.WriteLine(numerosArray[3]); // Imprime o quarto elemento do array
Console.WriteLine(numerosArray[4]); // Imprime o quinto elemento do array


Console.WriteLine("---------------------------");

// List
List<int> numerosList = new List<int>(); // Lista de inteiros   
numerosList.Add(1); // Adiciona o elemento 1 à lista
numerosList.Add(2); // Adiciona o elemento 2 à lista    
numerosList.Add(3); // Adiciona o elemento 3 à lista

Console.WriteLine("Elementos da lista:");
foreach (var numero in numerosList)
{
    Console.WriteLine(numero);
}
*/

/*
Console.WriteLine("Seja bem vindo ao sistema de estacionamento!");
Console.WriteLine("Digite a placa do veículo: ");
string placa = Console.ReadLine();

Console.WriteLine("Digite a data e hora de entrada (ex: 17/04/2025 14:00): ");
DateTime dataEntrada = DateTime.Parse(Console.ReadLine());

Console.WriteLine("Digite a data e hora de saída (ex: 17/04/2025 14:00): ");
DateTime dataSaida = DateTime.Parse(Console.ReadLine());


// O usuário pode digitar qualquer um destes formatos:
// "17/04/2025 14:00"     
// "17/04/2025"           
// "17-04-2025 14:00"     
// "2025-04-17 14:00"     
// "17/04/2025 14:00:00"  




Console.WriteLine("Digite o valor da hora: ");
int valorHora = int.Parse(Console.ReadLine());

double valorTotal = 0;
Estacionamento estacionamento = new Estacionamento(placa, dataEntrada, dataSaida, valorHora, valorTotal);

estacionamento.CalcularValorTotal();
estacionamento.ExibirInformacoes(); 
*/


/*
// Solicita os dados ao usuário
Console.WriteLine("Bem-vindo ao sistema de cadastro de pessoas!");
Console.WriteLine("-----------------------------------");
Console.WriteLine("Digite o primeiro nome:");
string nome = Console.ReadLine();

Console.WriteLine("Digite o sobrenome:");
string sobrenome = Console.ReadLine();

Console.WriteLine("Digite a idade:");
int idade = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o CPF:");
string cpf = Console.ReadLine();

// Ajuste a ordem dos argumentos conforme o construtor da classe Pessoa
Pessoa pessoa = new Pessoa(nome, sobrenome, idade, cpf);
pessoa.ExibirInformacoes();
pessoa.ValidarDados(); // Valida os dados informados
*/




/*

Body expression (ou expressão de corpo) é uma sintaxe simplificada em C# para métodos, 
propriedades e construtores que possuem apenas uma única expressão a ser retornada ou 
executada. Utiliza o operador => (lambda) para tornar o código mais conciso e legível.

Exemplo em propriedade:
public string Nome => _nome;


Exemplo em método:
public int Soma(int a, int b) => a + b;

Vantagens:

Reduz a quantidade de código.
Facilita a leitura em membros simples.
Observação:
Use body expressions apenas quando a implementação for simples e direta. 
Para lógicas mais complexas, prefira o bloco tradicional

*/




/*

Modificadores de acesso definem a visibilidade de classes, métodos, propriedades e 
outros membros em relação a outras partes do código. 
Eles controlam quem pode acessar ou modificar determinado membro.

Principais modificadores:

public: Acesso liberado para qualquer código.
private: Acesso restrito apenas à própria classe.
protected: Acesso permitido à própria classe e a classes derivadas.
internal: Acesso permitido apenas dentro do mesmo assembly/projeto.
protected internal: Acesso permitido dentro do mesmo assembly ou por classes derivadas.
private protected: Acesso permitido apenas dentro da própria classe ou classes derivadas no mesmo assembly.



// public: acessível de qualquer lugar
public class PessoaPublica
{
    public string Nome { get; set; }
}

--------

// private: acessível apenas dentro da própria classe
class PessoaPrivada
{
    private int idade;

    private void MostrarIdade()
    {
        Console.WriteLine(idade);
    }
}

-------

// protected: acessível na classe e em classes derivadas
class PessoaBase
{
    protected string documento;
}

class PessoaDerivada : PessoaBase
{
    public void MostrarDocumento()
    {
        Console.WriteLine(documento); // permitido
    }
}

------

// internal: acessível apenas dentro do mesmo assembly/projeto
internal class PessoaInterna
{
    internal void MostrarMensagem()
    {
        Console.WriteLine("Mensagem interna");
    }
}

-------

// protected internal: acessível no mesmo assembly ou em classes derivadas
class PessoaProtegidaInterna
{
    protected internal int codigo;
}

-------

// private protected: acessível na própria classe ou em derivadas no mesmo assembly
class PessoaPrivadaProtegida
{
    private protected int


Resumo:
Os modificadores de acesso ajudam a proteger dados e a organizar o encapsulamento no código, tornando-o mais seguro e estruturado.


*/


/*
Pessoa pessoa = new Pessoa();
pessoa.Nome = "João";
pessoa.Sobrenome = "Silva";
pessoa.Idade = 25;

Pessoa pessoa2 = new Pessoa("Maria", "Oliveira", 30, "98765432100"); // Segunda forma de instanciar a classe Pessoa

Pessoa pessoa3 = new Pessoa(nome: "Pedro", sobrenome: "Santos", idade: 22, cpf: "12345678900"); // Terceira forma de instanciar a classe Pessoa, usando nomeação de parâmetros

Curso cursoDeTi = new Curso();
cursoDeTi.Nome = "Curso de C# Avançado";

cursoDeTi.Alunos = new List<Pessoa>();

cursoDeTi.AdicionarAluno(pessoa);
cursoDeTi.AdicionarAluno(pessoa2);
cursoDeTi.AdicionarAluno(pessoa3);

cursoDeTi.ListarAlunos();

cursoDeTi.ListarAlunosMatriculados();

cursoDeTi.RemoverAluno(pessoa);
cursoDeTi.RemoverAluno(pessoa2);
cursoDeTi.RemoverAluno(pessoa3);
*/



/*
Concatenação de strings:
string nome = "João";
string sobrenome = "Silva";
string nomeCompleto = nome + " " + sobrenome; // Usando o operador +
Console.WriteLine(nomeCompleto); // Imprime "João Silva"


Interpolação de strings:
string nomeCompletoInterpolado = $"{nome} {sobrenome}"; // Usando interpolação
Console.WriteLine(nomeCompletoInterpolado); // Imprime "João Silva"
*/


/*

Concatenação de valores:
string valor1 = "10";
string valor2 = "20";
string resultado = valor1 + valor2; // Concatena as strings
Console.WriteLine(resultado); // Imprime "1020"


int valor1 = 10;
int valor2 = 20;
int resultado = valor1 + valor2; // Soma os valores
Console.WriteLine(resultado); // Imprime 30


string valor1 = "10";
int valor2 = 20;
string resultado = valor1 + valor2; // Concatena a string com o inteiro
Console.WriteLine(resultado); // Imprime "1020" (o inteiro é convertido para string


string valor1 = "10";
int valor2 = 20;
int resultado = int.Parse(valor1) + valor2; // Converte a string para inteiro e soma
Console.WriteLine(resultado); // Imprime 30

*/


/*
Valores monetários:

decimal valorMonetario = 19.99m; // Usando o sufixo 'm' para indicar que é um decimal
Console.WriteLine(valorMonetario); // Imprime 19.99


decimal valorMonetario = 19.99m;
Console.WriteLine($"{valorMonetario:C}"); // Imprime "R$ 19,99"

*/