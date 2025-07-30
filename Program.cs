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
Tipos de dados primitivos:
int inteiro = 10; // Tipo inteiro
double decimalPontoFlutuante = 3.14; // Tipo ponto flutuante
bool booleano = true; // Tipo booleano
char caractere = 'A'; // Tipo caractere
string texto = "Olá, Mundo!"; // Tipo texto
decimal valorMonetario = 19.99m; // Tipo decimal para valores monetários
DateTime dataHora = DateTime.Now; // Tipo data e hora

Declarações de variáveis:

int numero = 5; // Declaração de variável inteira

string nome = "João"; // Declaração de variável de texto

bool ativo = true; // Declaração de variável booleana

double preco = 19.99f; // Declaração de variável de ponto flutuante usa-se a letra f

char letra = 'A'; // Declaração de variável de caractere sempre com aspas simples

decimal valor = 100.50m; // Declaração de variável decimal para valores monetários

Usar literais de ponto flutuante
Um número de ponto flutuante é um número que contém uma decimal, por exemplo, 3.14159. 
O C# dá suporte a três tipos de dados para representar números decimais: 

float -> float peso = 70.5f; // Declaração de variável de ponto flutuante usa-se a letra f

double -> double preco = 19.99d; // Declaração de variável de ponto flutuante usa-se a letra d

decimal -> decimal valor = 19.99m; // Declaração de variável decimal usa-se a letra m

Cada tipo dá suporte a diferentes graus de precisão.
Float Type    Precision
----------------------------
float         ~6-9 digits
double        ~15-17 digits
decimal        28-29 digits

*/


/*
Referência de tipos:

Tipos de referência são tipos de dados que armazenam uma referência a um objeto na memória, em vez de armazenar o valor real. 
Isso significa que, quando você atribui um tipo de referência a outra variável, ambas as variáveis apontam para o mesmo objeto na memória.

Exemplo de tipos de referência:
- Classes
- Arrays
- Delegates
- Strings (embora sejam imutáveis, são tipos de referência)

int[] ref_A= new int[1];
ref_A[0] = 2;
int[] ref_B = ref_A;
ref_B[0] = 5;

Console.WriteLine("--Reference Types--");
Console.WriteLine($"ref_A[0]: {ref_A[0]}");
Console.WriteLine($"ref_B[0]: {ref_B[0]}");




/*
Console.WriteLine("Tipos integrais assinados:");

Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");

Console.WriteLine("");
Console.WriteLine("Tipos integrais não assinados:");

Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");


Console.WriteLine("");
Console.WriteLine("Floating point types:");
Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");
*/


/*
Para simplificar:

int para a maioria dos números inteiros
decimal para números que representam dinheiro
bool para valores true ou false
string para valor alfanumérico
Escolha tipos complexos especializados para situações especiais
Não reinvente os tipos de dados se um ou mais já existirem para uma determinada finalidade. Os seguintes exemplos identificam quando um tipo de dados .NET específico pode ser útil:

byte: para trabalhar com dados codificados provenientes de outros sistemas de computação ou que usam diferentes conjuntos de caracteres.
double: para trabalhar com fins geométricos ou científicos. double é usado com frequência ao criar jogos que envolvem movimento.
System.DateTime para um valor de data e hora específico.
System.TimeSpan para um intervalo de anos/mês/dias/horas/minutos/segundos/milissegundos.
*/

/*
Tipos de dados compostos:
List<int> numeros = new List<int>(); // Lista de inteiros

Dictionary<string, int> dicionario = new Dictionary<string, int>(); // Dicionário com chave string e valor inteiro

Tuple<string, int> tupla = new Tuple<string, int>("João", 25); // Tupla com dois elementos: string e inteiro

Array<int> numerosArray = new int[5]; // Array de inteiros com tamanho fixo

List<string> nomes = new List<string> { "Ana", "Maria", "Pedro" }; // Lista de strings com inicialização direta

// Declaração de variáveis compostas

List<string> frutas = new List<string>(); // Declaração de lista de strings
frutas.Add("Maçã"); // Adiciona "Maçã" à lista
frutas.Add("Banana"); // Adiciona "Banana" à lista

Dictionary<string, int> idades = new Dictionary<string, int>(); // Declaração de dicionário com chave string e valor inteiro
idades.Add("João", 25); // Adiciona a chave "João" com valor 25
idades.Add("Maria", 30); // Adiciona a chave "Maria" com valor 30

// Declaração de tupla com dois elementos: string e inteiro
Tuple<string, int> pessoa = new Tuple<string, int>("Ana", 28); //
// Declaração de array de inteiros com tamanho fixo
int[] numerosArray = new int[5]; // Declaração de array de inteiros
numerosArray[0] = 10; // Atribui o valor 10 ao primeiro elemento do array
numerosArray[1] = 20; // Atribui o valor 20 ao segundo elemento do array

// Declaração de lista de strings com inicialização direta
List<string> nomes = new List<string> { "Carlos", "Fernanda", "Lucas" }; // Declaração de lista de strings com inicialização direta

// Adiciona mais elementos à lista
nomes.Add("Ana"); // Adiciona "Ana" à lista
nomes.Add("Pedro"); // Adiciona "Pedro" à lista

// Declaração de lista de inteiros com inicialização direta
List<int> numeros = new List<int> { 1, 2, 3, 4, 5 }; // Declaração de lista de inteiros com inicialização direta

// Adiciona mais elementos à lista
numeros.Add(6); // Adiciona 6 à lista

// Declaração de dicionário com chave string e valor inteiro
Dictionary<string, int> dicionario = new Dictionary<string, int>
{
    { "João", 25 }, // Adiciona a chave "João" com valor 25
    { "Maria", 30 } // Adiciona a chave "Maria" com valor 30
};
*/

/*
Constantes:
const int numeroMaximo = 100; // Declaração de constante inteira
const double PI = 3.14159;
const string mensagem = "Bem-vindo ao C#";
const int maxTentativas = 5;
const string caminhoArquivo = "C:\\arquivos\\dados.txt"; // Declaração de constante de string
const bool ativo = true; // Declaração de constante booleana    
*/


/*
Regras de nomenclatura:
- Nomes de variáveis devem ser descritivos e começar com letra minúscula.
- Nomes de classes devem começar com letra maiúscula e usar PascalCase: 
    Pessoa, Curso, Estacionamento.

- Nomes de propriedades devem começar com letra maiúscula e usar PascalCase:
    Idade, CPF, Nome, Sobrenome.

- Nomes de métodos devem começar com letra minúscula e usar camelCase:
    validarDados, exibirInformacoes, adicionarAluno, removerAluno.

- Nomes de constantes devem ser escritos em letras maiúsculas e usar snake_case:
    MAX_TENTATIVAS, CAMINHO_ARQUIVO, VALOR_HORA.
*/


/*
// Exemplo de uso de Console.WriteLine com formatação
Console.WriteLine("Hello\nWorld!");
Saída: Hello
      World!

Console.WriteLine("Hello\tWorld!");
Saída: Hello    World!


Console.WriteLine("Hello \"World\"!");
Saída: Hello "World"!


Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ... \n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");

Saída: 

Generating invoices for customer "Contoso Corp" ...

Invoice: 1021           Complete!
Invoice: 1022           Complete!

Output Directory:
*/



/* 
 Caracteres de Escape Unicode em C#

  Definição:
  - Permitem inserir símbolos Unicode em strings usando códigos UTF-16.
  - Sintaxe: \uXXXX (XXXX = 4 dígitos hexadecimais)

  Exemplos:
  Console.WriteLine("\u00A9 2025 Copilot");        // © 2025 Copilot
  Console.WriteLine("\u3053\u3093\u306B\u3061\u306F"); // こんにちは (Olá em japonês)

  Aplicações:
  - Exibir textos em idiomas não latinos
  - Mostrar emojis e símbolos gráficos (\u263A = ☺, \u2665 = ♥)

  Cuidados:
  - Alguns consoles não exibem todos os caracteres Unicode corretamente
  - Caracteres fora do UTF-16 exigem métodos como char.ConvertFromUtf32()
    Exemplo: Console.WriteLine(char.ConvertFromUtf32(0x1F60A)); // 
  - Sequências incorretas geram erro: Unrecognized escape sequence

  Dica:
  - Use @ antes da string para preservar formatação:
    Console.WriteLine(@"\u2600 está ensolarado hoje!"); // exibe literalmente \u2600
*/


/*
Calculos simples:
int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
int quotient = 7 / 5;

Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference);
Console.WriteLine("Product: " + product);
Console.WriteLine("Quotient: " + quotient);
*/



/*
Incrementar e decrementar valores:
int value = 0;     // O valor agora é 0
value = value + 5; // O valor agora é 5
value += 5;        // O valor agora é 10.



int value = 0;     // O valor agora é 0.
value = value + 1; // O valor agora é 1.
value++;           // O valor agora é 2.



/*
Truncar valores:

Trucar quer dizer remover a parte decimal de um número, mantendo apenas a parte inteira.

double pi = 3.14159;
int inteiro = (int)pi; // Trunca o valor de pi para 3
Console.WriteLine(inteiro);
*/



/*
Operadores de comparação:
string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(pangram.Contains("fox"));
Console.WriteLine(pangram.Contains("cow"));
*/


/*
Blocos de código e escopo de variável

bool flag = true;
if (flag)
{
    int value = 10;
    Console.WriteLine($"Inside the code block: {value}");
}

Nesse caso a variável value só existe dentro do bloco if.
Fora do bloco, a variável value não é acessível, sendo assim caso o código abaixo seja executado, dará erro:

bool flag = true;
if (flag)
{
    int value = 10;
    Console.WriteLine($"Inside the code block: {value}");
}
Console.WriteLine($"Outside the code block: {value}");


Para corrigir o erro, precisamos declarar a variável value fora do bloco if:
bool flag = true;
int value;

if (flag)
{
    Console.WriteLine($"Inside the code block: {value}");
}

value = 10;
Console.WriteLine($"Outside the code block: {value}");
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

// Conversão de tipos numéricos
decimal myDecimal = 1.23456789m;
float myFloat = (float)myDecimal;

Console.WriteLine($"Decimal: {myDecimal}");
Console.WriteLine($"Float  : {myFloat}");

// Conversão implícita
int myInt = 3;
Console.WriteLine($"int: {myInt}");

decimal myDecimal = myInt;
Console.WriteLine($"decimal: {myDecimal}");

// Conversão explícita
int first = 5;
int second = 7;
string message = first.ToString() + second.ToString();
Console.WriteLine(message);


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

// Conversão de string para inteiro
string first = "5";
string second = "7";
int sum = int.Parse(first) + int.Parse(second);
Console.WriteLine(sum);


// Conversão de string para inteiro com Convert
string value1 = "5";
string value2 = "7";
int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(result);


// Casting e conversão de tipos numéricos
int value = (int)1.5m; // casting converte um decimal para um inteiro, truncando a parte decimal
Console.WriteLine(value); // Saída: 1


// Convert.ToInt32 arredonda o valor para o inteiro mais próximo
int value2 = Convert.ToInt32(1.5m); // converting arredonda para cima
Console.WriteLine(value2); // Saída: 2

*/

/*

Use TryParse()
O método TryParse() faz várias coisas simultaneamente:

Ele tenta converter uma cadeia de caracteres para o tipo de dado numérico fornecido.
Se a conversão der certo, o valor convertido é armazenado em um parâmetro de saída, explicado na seção a seguir.
Retorna um bool para indicar se a ação foi bem-sucedida ou falhou.

Output:
if (int.TryParse(value, out result))

// Exemplo de uso do TryParse

string value = "102";
int result = 0;
if (int.TryParse(value, out result))
{
   Console.WriteLine($"Measurement: {result}");
}
else
{
   Console.WriteLine("Unable to report the measurement.");
}

output: 102



// Exemplo de uso do TryParse
string value = "102";
int result = 0;
if (int.TryParse(value, out result))
{
   Console.WriteLine($"Measurement: {result}");
}
else
{
   Console.WriteLine("Unable to report the measurement.");
}
Console.WriteLine($"Measurement (w/ offset): {50 + result}");

output: 152

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
O operador ternário é uma forma concisa de escrever uma condição if-else
A sintaxe é: (condição) ? valor_se_verdadeiro : valor_se_falso


int saleAmount = 1001;
int discount = saleAmount > 1000 ? 100 : 50;
Console.WriteLine($"Discount: {discount}");

// O operador ternário é uma forma concisa de escrever uma condição if-else

int saleAmount = 1001;
// int discount = saleAmount > 1000 ? 100 : 50;

Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");

*/


/*
Randoms:

Random coin = new Random();
int flip = coin.Next(0, 2);
Console.WriteLine((flip == 0) ? "heads" : "tails");

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

Método SORT 

O método sort é usado para ordenar uma coleção de elementos, como um array ou uma lista.
// Exemplo de uso do método Sort com um array de strings

string[] pallets = [ "B14", "A11", "B12", "A13" ];

Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
// Saída:
-- A11
-- A13
-- B12
-- B14

Para inverter a ordem dos paletes usando o método Array.Reverse()

string[] pallets = [ "B14", "A11", "B12", "A13" ];

Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Console.WriteLine("Reversed...");
Array.Reverse(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

// Saída:
-- B14
-- B12
-- A13
-- A11
*/


/*
O método Array.Clear() permite eliminar o conteúdo de elementos específicos em sua matriz, substituindo-os pelo valor padrão da matriz. 
Por exemplo, se você limpar um elemento em uma matriz string, o valor desmarcado será substituído por null. 
Da mesma forma, quando você limpa um elemento em uma matriz int, a substituição é 0 (zero).

O método Array.Resize(), por outro lado, permite que você adicione ou remova elementos de sua matriz.

string[] pallets = [ "B14", "A11", "B12", "A13" ];
Console.WriteLine("");

Array.Clear(pallets, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}


Saida:

Clearing 2 ... count: 4
-- 
-- 
-- B12
-- A13


// O método Array.Clear() é usado para limpar uma parte de um array, definindo os elementos especificados como seus valores padrão.

string[] pallets = [ "B14", "A11", "B12", "A13" ];
Console.WriteLine("");

Console.WriteLine($"Before: {pallets[0]}");
Array.Clear(pallets, 0, 2);
Console.WriteLine($"After: {pallets[0]}");

Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}




// Array.Resize() é um método que permite alterar o tamanho de um array, adicionando ou removendo elementos.

string[] pallets =  ["B14", "A11", "B12", "A13" ];
Console.WriteLine("");

Array.Clear(pallets, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Saída:

Clearing 2 ... count: 4
-- 
-- 
-- B12
-- A13

Resizing 6 ... count: 6
-- 
-- 
-- B12
-- A13
-- C01
-- C02


É possível remover elementos nulos de uma matriz?
Se o método Array.Resize() não remover elementos vazios de uma matriz, há outro método auxiliar que faz o trabalho automaticamente? 
Não. A melhor maneira de esvaziar os elementos de uma matriz é contar o número de elementos não nulos percorrendo cada item e incrementando uma variável (contador). 
Em seguida, você criará uma segunda matriz que tem o tamanho da variável do contador. Por fim, você executará um loop em cada elemento na matriz original e copiará valores não nulos na nova matriz.

*/


/*

Inverter uma string usando Array.Reverse()

string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
string result = new string(valueArray);
Console.WriteLine(result); // saída: 321cba



Inverter uma string usando String.Join() para separar os caracteres com vírgula

string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
// string result = new string(valueArray);
string result = String.Join(",", valueArray);
Console.WriteLine(result); // saída: 3,2,1,c,b,a



Invertendo uma string e separando os caracteres com vírgula, gerando no final uma string de caracteres separados por vírgula

string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
// string result = new string(valueArray);
string result = String.Join(",", valueArray);
Console.WriteLine(result);

string[] items = result.Split(',');
foreach (string item in items)
{
    Console.WriteLine(item);
}


// DESAFIO DE CÓDIGO
Inverter uma string e separar os caracteres com vírgula sem alterar a string original

string pangram = "The quick brown fox jumps over the lazy dog";

// Step 1
string[] message = pangram.Split(' ');

//Step 2
string[] newMessage = new string[message.Length];

// Step 3
for (int i = 0; i < message.Length; i++)
{
    char[] letters = message[i].ToCharArray();
    Array.Reverse(letters);
    newMessage[i] = new string(letters);
}

//Step 4
string result = String.Join(" ", newMessage);
Console.WriteLine(result);



DESAFIO DE CÓDIGO 2:


string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
Observe que no código anterior, a variável orderStream contém um string de várias IDs de pedido separadas por vírgulas.

Adicione o código abaixo do código anterior para analisar as "IDs de pedido" do de pedidos de entrada string e armazenar as "IDs do pedido" em uma matriz.

Adicione o código para gerar cada "ID do pedido" na ordem classificada e marque os pedidos que não tiverem exatamente quatro caracteres como "- Erro".


// Declara uma string com códigos de pedidos separados por vírgula
string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

// Separa a string em um array de strings, usando a vírgula como delimitador
string[] items = orderStream.Split(',');

// Ordena os itens em ordem alfabética (como palavras)
Array.Sort(items);

// Percorre cada item ordenado
foreach (var item in items)
{
    // Verifica se o código tem exatamente 4 caracteres
    if (item.Length == 4)
    {
        // Se sim, imprime o código normalmente
        Console.WriteLine(item);
    }
    else
    {
        // Se não, imprime o código com uma mensagem de erro
        Console.WriteLine(item + "\t- Error");
    }
}


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
do                        // do-while executa um bloco de código pelo menos uma vez, mesmo que a condição seja falsa
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
using System;

class Program
{
    static void Main()
    {
        Random random = new Random();

        int heroHealth = 10;
        int monsterHealth = 10;

        do
        {
            // Herói ataca
            int heroAttack = random.Next(1, 11);
            monsterHealth -= heroAttack;
            Console.WriteLine($"Monstro foi atacado e perdeu {heroAttack} de vida. Agora tem {Math.Max(monsterHealth, 0)} de vida.");

            // Monstro só contra-ataca se estiver vivo
            if (monsterHealth > 0)
            {
                int monsterAttack = random.Next(1, 11);
                heroHealth -= monsterAttack;
                Console.WriteLine($"Herói foi atacado e perdeu {monsterAttack} de vida. Agora tem {Math.Max(heroHealth, 0)} de vida.");
            }

        } while (heroHealth > 0 && monsterHealth > 0);

        Console.WriteLine(heroHealth > 0 ? "Herói venceu!" : "Monstro venceu!");
    }
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


Verificar se a lista está vazia:

if (!minhaLista.Any()) // Verifica se a lista está vazia
{
    Console.WriteLine("A lista está vazia.");
}
else
{
    Console.WriteLine("A lista contém elementos.");
}


if (minhaLista.Count == 0) // Outra forma de verificar se a lista está vazia
{
    Console.WriteLine("A lista está vazia.");
}
else
{
    Console.WriteLine("A lista contém elementos.");
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
Formatação Composta em C#

A formatação composta permite criar strings dinâmicas com marcadores numéricos (chaves como {0}, {1}, etc.)
que são substituídos por valores durante a execução do programa (runtime).
  
Exemplo:
string first = "Hello";
string second = "World";
string result = string.Format("{0} {1}!", first, second);
Console.WriteLine(result); // Saída: Hello World!
 
  - {0} será substituído por "Hello" (variável 'first')
  - {1} será substituído por "World" (variável 'second')
  
   Vantagens:
  - Organiza melhor o código comparado à concatenação manual.
  - Permite reutilizar valores: "{0} {0}" → "Hello Hello"
  - Você pode alterar a ordem: "{1} {0}" → "World Hello"
  
Alternativa moderna (desde C# 6.0): Interpolação de strings
string result = $"{first} {second}!";
  
Mais legível e direta, produz o mesmo resultado: Hello World!



Interpolação com formatação monetária:
decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:C} (Save {discount:C})"); 

Saída: Price: R$ 123,45 (Save R$ 50,00)
// O formato {price:C} formata o valor como moeda, usando a cultura atual do sistema.
// O formato {discount:C} também formata o valor como moeda, usando a cultura atual do sistema.
// A interpolação de strings é uma maneira mais legível e concisa de formatar strings

 */

/*
 Formatação de números em C#

 Ao lidar com valores numéricos, é comum formatá-los para facilitar a leitura,
 utilizando separadores de milhar e definindo a quantidade de casas decimais.

 O especificador "N" serve para formatar números com separadores e duas casas decimais por padrão.

 Exemplo:
 decimal measurement = 123456.78912m;
 Console.WriteLine($"Measurement: {measurement:N} units");
 // Saída com cultura en-US: "Measurement: 123,456.79 units"

 Para ajustar a precisão, adicione um número ao especificador:
 Console.WriteLine($"Measurement: {measurement:N4} units");
 // Saída: "Measurement: 123,456.7891 units"

 A exibição pode variar de acordo com a cultura:
 - en-US → 123,456.79
 - pt-BR → 123.456,79

 Outros especificadores disponíveis:
 - "C" para moeda → {valor:C}
 - "P" para porcentagem → {taxa:P2}

 Essas opções tornam a saída dos dados numéricos mais clara e adequada ao público.
*/



/*
 Formatação de percentuais em C#

 O especificador de formato "P" é usado para exibir valores numéricos como porcentagens.
 Por padrão, "P" multiplica o valor por 100 e adiciona o símbolo de porcentagem (%).

 A notação "P2" arredonda o resultado para duas casas decimais.

 Exemplo:
 decimal tax = 0.36785m;
 Console.WriteLine($"Tax rate: {tax:P2}");
 // Saída com cultura en-US: "Tax rate: 36.79%"

 Para maior ou menor precisão, basta ajustar o número após o "P":
 - "P0" → sem casas decimais
 - "P3" → três casas decimais

 A saída depende da cultura do sistema:
 - en-US → "36.79%"
 - pt-BR → "36,79%"

 Isso torna a apresentação de valores proporcionais mais clara e padronizada.
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


/*
Convertendo valores monetários:

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");
decimal valorMonetario = 19.99m;
Console.WriteLine($"{valorMonetario:C}"); // Imprime "R$ 19,99"

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
Console.WriteLine($"{valorMonetario:C}"); // Imprime "$19.99"

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("fr-FR");
Console.WriteLine($"{valorMonetario:C}"); // Imprime "19,99 €
*/

/*
Alterando a localização da cultura:
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

var valorMonetario = 19.99m;
Console.WriteLine($"{valorMonetario.ToString("C", CultureInfo.CurrentSpecificCulture("en-US"))}"); // Imprime "$19.99" (formato monetário americano)
*/



/*
Personalizando a exibição monetária:
CultureInfo cultura = new CultureInfo("pt-BR");

Console.WriteLine($"{valorMonetario.ToString("C1", cultura)}"); // Exibe o valor monetário com uma casa decimal
Console.WriteLine($"{valorMonetario.ToString("C2", cultura)}"); // Exibe o valor monetário com duas casas decimais
Console.WriteLine($"{valorMonetario.ToString("C3", cultura)}"); // Exibe o valor monetário com três casas decimais
*/



/*
Representando porcentagens:
double porcentagem = 0.25; // 25%
Console.WriteLine($"{porcentagem:P}"); // Imprime "25,00 %"

double porcentagem = .3421; // 34.21%
Console.WriteLine($"{porcentagem:P2}"); // Imprime "34,21 %"

int numero = 123456;
Console.WriteLine(numero.ToString("##-##-##")); // Imprime "123-45-67"
Console.WriteLine(numero.ToString("000-000-000")); // Imprime "123-456-000"
*/


/*
Formatação de data e hora:
DateTime data = DateTime.Now;
Console.WriteLine(data); // Imprime a data e hora atual

Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm")); // Imprime a data no formato "dia/mês/ano hora:minuto"


Console.WriteLine(data.ToString("dd/MM/yyyy hh:mm")); // Imprime a data no formato "dia/mês/ano hora:minuto" (12 horas)

Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm:ss")); // Imprime a data no formato "dia/mês/ano hora:minuto:segundo"


DateTime data = DateTime.Parse("17/04/2025 14:00"); // Converte uma string para DateTime
Console.WriteLine(data); // Imprime a data convertida 

DateTime data = DateTime.Parse("32/04/2025 14:00"); // Converte uma string para DateTime
Console.WriteLine(data); // Imprime a data convertida (lança uma exceção se a string não for válida)




string dataString = "2022-13-17 14:00"; // Data inválida

DateTime.TryParseExact(dataString, 
                        "yyyy-MM-dd HH:mm", 
                        CultureInfo.InvariantCulture, 
                        DateTimeStyles.None, 
                        out DateTime dataConvertida);

Console.WriteLine(data); // Imprime a data convertida (se a conversão falhar, data será DateTime.MinValue)


Outra forma:

bool sucesso = DateTime.TryParseExact(dataString, 
                        "yyyy-MM-dd HH:mm", 
                        CultureInfo.InvariantCulture, 
                        DateTimeStyles.None, 
                        out DateTime dataConvertida);

if (sucesso)
{
    Console.WriteLine($"Conversão realizada com sucesso! Data {dataConvertida}");
}
else
{
    Console.WriteLine($"{dataString} não é uma data válida.");
}

*/


/*          
Leitura de arquivos .txt:

string[] linhas = File.ReadAllLines("arquivos/leitura.txt"); // Lê todas as linhas do arquivo .txt
foreach (string linha in linhas)
{
    Console.WriteLine(linha); // Imprime cada linha do arquivo
}
*/


/*

REGRAS DE NEGÓCIO:

Se o usuário for um administrador com um nível maior que 55, exiba a mensagem:
Welcome, Super Admin user.


Se o usuário for um administrador com um nível menor ou igual a 55, exiba a mensagem:
Welcome, Admin user.


Se o usuário for um gerente com um nível maior ou igual a 20, exiba a mensagem:
Contact an Admin for access.


Se o usuário for um gerente com um nível menor que 20, exiba a mensagem:
You do not have sufficient privileges.


Se o usuário não for um Administrador ou um Gerente, gere a mensagem:
You do not have sufficient privileges.

*/

/*
string permission = "Admin|Manager";
int level = 55;
string adminLevel;

if (permission.Contains("Admin"))
{
    if (level > 55)
    {
        adminLevel = "Super Admin";
        Console.WriteLine($"Welcome, {adminLevel} user.");
    }
    else
    {
        adminLevel = "Admin";
        Console.WriteLine($"Welcome, {adminLevel} user.");
    }
}
else if (permission.Contains("Manager"))
{
    if (level >= 20)
    {
        Console.WriteLine("Contact an Admin for access.");
        return;
    }
    else
    {
        Console.WriteLine("You do not have sufficient privileges.");
        return;
    }
}
else
{
    Console.WriteLine("You do not have sufficient privileges.");
    return;
}
*/


// REFATORAÇÃO:

/*
string permission = "Admin|Manager";
int level = 55;

CheckUserAccess(permission, level);

void CheckUserAccess(string permission, int level)
{
    if (permission.Contains("Admin"))
    {
        Console.WriteLine(level > 55 ? "Welcome, Super Admin user." : "Welcome, Admin user.");
        return;
    }

    if (permission.Contains("Manager"))
    {
        Console.WriteLine(level >= 20 ? "Contact an Admin for access." : "You do not have sufficient privileges.");
        return;
    }

    Console.WriteLine("You do not have sufficient privileges.");
}
*/










// DESAFIOS DE CÓDIGO:

/*

Projeto de código 1 – escrever o código que valida a entrada de inteiro
Veja as seguintes condições que seu primeiro projeto de codificação deve implementar:

A solução deve incluir uma iteração do-while ou while.

Antes do bloco de iteração: a solução deve usar uma instrução Console.WriteLine() para solicitar ao usuário um valor inteiro entre 5 e 10.

Dentro do bloco de iteração:

A solução deve usar uma instrução Console.ReadLine() para obter uma entrada do usuário.
A solução deve garantir que a entrada seja uma representação válida de um inteiro.
Se o valor inteiro não estiver entre 5 e 10, o código deverá usar uma instrução Console.WriteLine() para solicitar ao usuário um valor inteiro entre 5 e 10.
A solução deve garantir que o valor inteiro esteja entre 5 e 10 antes de sair da iteração.
Abaixo (depois) do bloco de código de iteração: a solução deve usar uma instrução Console.WriteLine() para informar ao usuário que o valor de entrada foi aceito.

Verifique se você tem o arquivo Program.cs vazio aberto no Visual Studio Code.

Se necessário, abra o Visual Studio Code e conclua as seguintes etapas para preparar o arquivo Program.cs no Editor:

No menu Arquivo, selecione Abrir Pasta.

Use a caixa de diálogo Abrir Pasta para navegar e, em seguida, abra a pasta CsharpProjects.

No painel EXPLORER do Visual Studio Code, selecione Program.cs.

No menu Seleção do Visual Studio Code, escolha Selecionar Tudo e pressione a tecla Delete.

Escreva o código que implementa cada condição do projeto de código 1.

Execute o aplicativo e verifique se o código valida a entrada do usuário com base nos requisitos especificados.

Por exemplo, quando você executa o aplicativo, ele deve rejeitar valores de entrada como "dois" e "2", mas aceitar um valor de entrada de "7".


string? readResult;
string valueEntered = "";
int numValue = 0;
bool validNumber = false;

Console.WriteLine("Enter an integer value between 5 and 10");

do
{
    readResult = Console.ReadLine();
    if (readResult != null) 
    {
        valueEntered = readResult;
    }

    validNumber = int.TryParse(valueEntered, out numValue);

    if (validNumber == true)
    {
        if (numValue <= 5 || numValue >= 10)
        {
            validNumber = false;
            Console.WriteLine($"You entered {numValue}. Please enter a number between 5 and 10.");
        }
    }
    else 
    {
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
    }
} while (validNumber == false);

Console.WriteLine($"Your input value ({numValue}) has been accepted.");

readResult = Console.ReadLine();




*/




// SEGUNDO DESAFIO:

/*
Projeto de código 2 – escrever o código que valida a entrada de cadeia de caracteres
Veja as seguintes condições que seu segundo projeto de codificação deve implementar:

A solução deve incluir uma iteração do-while ou while.

Antes do bloco de iteração: a solução deve usar uma instrução Console.WriteLine() para solicitar ao usuário um dos três nomes de função: Administrador, Gerente ou Usuário.

Dentro do bloco de iteração:

A solução deve usar uma instrução Console.ReadLine() para obter uma entrada do usuário.
A solução deve garantir que o valor inserido corresponda a uma das três opções de função.
Sua solução deve usar o método Trim() no valor de entrada para ignorar caracteres de espaço de entrelinhamento e à direita.
A solução deve usar o método ToLower() no valor de entrada para ignorar maiúsculas e minúsculas.
Se o valor inserido não corresponder a uma das opções de função, o código deverá usar uma instrução Console.WriteLine() para solicitar ao usuário uma entrada válida.
Abaixo (depois) do bloco de código de iteração: a solução deve usar uma instrução Console.WriteLine() para informar ao usuário que o valor de entrada foi aceito.

Remover todo o código no painel Editor do Visual Studio Code

Selecionar todas as linhas de código no editor de código
No menu Editar, selecione Ativar comentário de bloco.
Escreva o código que implementa cada condição do projeto de código 2.

Execute o aplicativo e verifique se o código valida a entrada do usuário com base nos requisitos especificados.

Por exemplo, quando você executa o aplicativo, ele deve rejeitar um valor de entrada como "Admin", mas aceitar um valor de entrada "administrador".

string? readResult;
string roleName = "";
bool validEntry = false;

do
{                
    Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
    readResult = Console.ReadLine();
    if (readResult != null) 
    {
        roleName = readResult.Trim();
    }

    if (roleName.ToLower() == "administrator" || roleName.ToLower() == "manager" || roleName.ToLower() == "user") 
    {
        validEntry = true;
    }
    else
    {
        Console.Write($"The role name that you entered, \"{roleName}\" is not valid. ");
    }

} while (validEntry == false);

Console.WriteLine($"Your input value ({roleName}) has been accepted.");
readResult = Console.ReadLine();

*/


// TERCEIRO DESAFIO:

/*

Projeto de código 3: escreva um código que processe o conteúdo de uma matriz de caracteres
Veja as seguintes condições que seu terceiro projeto de codificação deve implementar:

A solução deve usar a seguinte matriz de cadeia de caracteres para representar a entrada para a lógica de codificação:

c#

Copiar
string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
A solução deve declarar uma variável inteira chamada periodLocation que pode ser usada para manter o local do caractere de ponto dentro de uma cadeia de caracteres.

A solução deve incluir um loop foreach ou for externo que possa ser usado para processar cada elemento da cadeia de caracteres na matriz. A variável da cadeia de caracteres que será processada dentro dos loops deve ser chamada de myString.

No loop externo, a solução deve usar o método IndexOf() da classe String para obter a localização do primeiro caractere de ponto na variável myString. A chamada de método deve ser semelhante a: myString.IndexOf("."). Se não houver nenhum caractere de ponto na cadeia de caracteres, um valor de -1 será retornado.

A solução deve incluir um loop do-while ou while interno que possa ser usado para processar a variável myString.

No loop interno, a solução deve extrair e exibir (gravar no console) cada frase contida em cada uma das cadeias de caracteres processadas.

No loop interno, a solução não deve exibir o caractere de ponto.

No loop interno, a solução deve usar os métodos Remove(), Substring() e TrimStart() para processar as informações da cadeia de caracteres.

Remover todo o código no painel Editor do Visual Studio Code

Selecionar todas as linhas de código no editor de código
No menu Editar, selecione Ativar comentário de bloco.
Escreva o código que implementa cada condição listada para o projeto de código 3.

Execute o aplicativo e verifique se a saída atende aos requisitos.

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int stringsCount = myStrings.Length;

string myString = "";
int periodLocation = 0;

for (int i = 0; i < stringsCount; i++)
{
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");

    string mySentence;

    // extract sentences from each string and display them one at a time
    while (periodLocation != -1)
    {

        // first sentence is the string value to the left of the period location
        mySentence = myString.Remove(periodLocation);

        // the remainder of myString is the string value to the right of the location
        myString = myString.Substring(periodLocation + 1);

        // remove any leading white-space from myString
        myString = myString.TrimStart();

        // update the comma location and increment the counter
        periodLocation = myString.IndexOf(".");

        Console.WriteLine(mySentence);
    }
 
    mySentence = myString.Trim();
    Console.WriteLine(mySentence);
}

*/

/*

EXEMPLO DE FORMATAÇÃO DE NÚMEROS E MOEDA:

int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");
Console.WriteLine($"   Shares: {productShares:N3} Product");
Console.WriteLine($"     Sub Total: {subtotal:C}");
Console.WriteLine($"           Tax: {taxPercentage:P2}");
Console.WriteLine($"     Total Billed: {total:C}");

*/


/*

Exemplo de uso do método PadLeft para formatar uma string, adicionando espaços à esquerda para que a string tenha um comprimento total de 40 caracteres:

string input = "Pad this";
Console.WriteLine(input.PadLeft(40));

Saída: 
                                       Pad this

/*
 Método sobrecarregado em C#

 Em C#, um método sobrecarregado é uma versão alternativa de um método existente,
 que aceita diferentes conjuntos de argumentos. Isso permite flexibilizar o uso
 do método para diferentes cenários.

 Por exemplo, o método PadLeft() pode ser chamado com apenas um argumento
 (comprimento total desejado), ou com dois argumentos (comprimento e caractere
 de preenchimento). A segunda versão é uma sobrecarga.

 Exemplo:
 Console.WriteLine(input.PadLeft(12, '-'));
 Console.WriteLine(input.PadRight(12, '-'));

 O primeiro adiciona o caractere '-' à esquerda da string até atingir 12 caracteres.
 O segundo faz o mesmo à direita.

 Saída:
 ----Pad this
 Pad this----
*/


/*
 Formatação com campos fixos em C#

 Este exemplo demonstra como criar uma linha de saída formatada com espaços
 reservados fixos para cada informação: ID de pagamento, nome do favorecido
 e valor do pagamento.

 A função PadRight() é usada para garantir que os dados ocupem exatamente
 o número de caracteres especificado, alinhando o conteúdo à esquerda.
 Já PadLeft() alinha o conteúdo à direita dentro do campo.

 Exemplo:
 string paymentId = "769C";
 string payeeName = "Mr. Stephen Ortega";
 string paymentAmount = "$5,000.00";

 var formattedLine = paymentId.PadRight(6);
 formattedLine += payeeName.PadRight(24);
 formattedLine += paymentAmount.PadLeft(10);
 Console.WriteLine(formattedLine);

 Resultado:
 "769C  Mr. Stephen Ortega        $5,000.00"

 O operador += concatena strings. Ele é equivalente a escrever:
 formattedLine = formattedLine + payeeName.PadRight(24);

 Essa abordagem é útil em cenários onde é necessário gerar saídas
 alinhadas para sistemas legados que exigem dados em posições fixas.


 string paymentId = "769C";
 string payeeName = "Mr. Stephen Ortega";
 string paymentAmount = "$5,000.00";

 var formattedLine = paymentId.PadRight(6);
 formattedLine += payeeName.PadRight(24);
 formattedLine += paymentAmount.PadLeft(10);

 Console.WriteLine(formattedLine);

 Saída:
 769C  Mr. Stephen Ortega       $5,000.00
*/


/*

DESAFIO DE CÓDIGO:


Use o novo conhecimento que você adquiriu sobre formatação de cadeias de caracteres para criar um aplicativo que possa mesclar e formatar 
o conteúdo adequado considerando a saída de exemplo acima. Preste muita atenção no espaço em branco e represente com precisão esse
formato exato usando o C#. Selecione e exclua todas as linhas de código no Editor do Visual Studio Code.
No Visual Studio Code, adicione o seguinte código para obter os dados para o desafio: 

string customerName = "Ms. Barros";
string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;
string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

// Your logic here
Console.WriteLine("Here's a quick comparison:\n");
string comparisonMessage = "";

// Your logic aqui
comparisonMessage += currentProduct.PadRight(20);
comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(10);
comparisonMessage += String.Format("{0:C}", currentProfit).PadRight(20);

comparisonMessage += "\n";
comparisonMessage += newProduct.PadRight(20);
comparisonMessage += String.Format("{0:P}", newReturn).PadRight(10);
comparisonMessage += String.Format("{0:C}", newProfit).PadRight(20);

Console.WriteLine(comparisonMessage);
Use o Editor do Visual Studio Code para gerar a mensagem com as variáveis e o código fornecidos. Você não pode excluir nenhum código existente, exceto os comentários. Verifique se o código gera a seguinte mensagem: Output Copiar Dear Ms. Barros, As a customer of our Magic Yield offering we are excited to tell you about a new financial product that would dramatically increase your return. Currently, you own 2,975,000.00 shares at a return of 12.75%. Our new product, Glorious Future offers a return of 13.13%. Given your current volume, your potential profit would be $63,000,000.00. Here's a quick comparison: Magic Yield 12.75% $55,000,000.00 Glorious Future 13.13% $63,000,000.00 Boa sorte!
*/

/*

SOLUTION:


string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

Console.WriteLine($"Dear {customerName},");
Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
Console.WriteLine($"Currently, you own {currentShares:N} shares at a return of {currentReturn:P}.\n");
Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P}.  Given your current volume, your potential profit would be {newProfit:C}.\n");

Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = "";

comparisonMessage = currentProduct.PadRight(20);
comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(10);
comparisonMessage += String.Format("{0:C}", currentProfit).PadRight(20);

comparisonMessage += "\n";
comparisonMessage += newProduct.PadRight(20);
comparisonMessage += String.Format("{0:P}", newReturn).PadRight(10);
comparisonMessage += String.Format("{0:C}", newProfit).PadRight(20);

Console.WriteLine(comparisonMessage);

*/

/*
Esse trecho de código em C# busca localizar a posição dos parênteses em uma string.

// Define uma string contendo um texto com parênteses
string message = "Find what is (inside the parentheses)";

// Procura pela posição do parêntese de abertura '(' na string
int openingPosition = message.IndexOf('(');

// Procura pela posição do parêntese de fechamento ')' na string
int closingPosition = message.IndexOf(')');

// Exibe a posição encontrada do parêntese de abertura
Console.WriteLine(openingPosition);

// Exibe a posição encontrada do parêntese de fechamento
Console.WriteLine(closingPosition);

Saída:
13
36
*/

/*
O método IndexOf() retorna o índice da primeira ocorrência de um caractere ou cadeia de caracteres.
O método LastIndexOf() retorna o índice da última ocorrência de um caractere ou cadeia de caracteres.
Ambos os métodos retornarão -1 se o caractere ou a cadeia de caracteres não forem encontrados.

string message = "hello there!";

// Armazena a posição da primeira ocorrência do caractere 'h' na variável first_h
int first_h = message.IndexOf('h');

// Armazena a posição da última ocorrência do caractere 'h' na variável last_h
int last_h = message.LastIndexOf('h');

// Exibe a mensagem informando as posições encontradas do caractere 'h'
Console.WriteLine($"For the message: '{message}', the first 'h' is at position {first_h} and the last 'h' is at position {last_h}.");
*/



/*

// A variável 'data' contém uma string com dados fixos: ID do cliente, nome, valor da fatura e número de itens.
// Os primeiros 5 caracteres representam o ID do cliente.
// Os próximos 20 caracteres representam o nome do cliente.
// Os próximos 6 representam o valor da fatura.
// Os últimos 3 representam a quantidade de itens na fatura.

string data = "12345John Smith          5000  3  ";

// O método Remove() é usado para remover os 20 caracteres correspondentes ao nome do cliente.
// Começa na posição 5 (após o ID) e remove 20 caracteres.
string updatedData = data.Remove(5, 20);

// Exibe a string atualizada, agora sem o nome do cliente.
Console.WriteLine(updatedData);

Saída: 
123455000  3




// A string 'message' contém dados com traços que precisam ser limpos ou substituídos.
string message = "This--is--ex-amp-le--da-ta";

// O método Replace() é usado para substituir todos os pares de traços '--' por um espaço.
message = message.Replace("--", " ");

// Em seguida, o método Replace() é chamado novamente para remover todos os traços restantes '-' da string.
message = message.Replace("-", "");

// Exibe a string resultante após as substituições.
Console.WriteLine(message);

Saída: 
This is example data

*/


/*

DESAFIO:

Extrair, substituir e remover dados de uma cadeia de caracteres de entrada
Selecione e exclua todas as linhas de código no Editor do Visual Studio Code.

No Visual Studio Code, adicione o seguinte código "starter" para obter os dados do desafio:

const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here

Console.WriteLine(quantity);
Console.WriteLine(output);
Se você executar o código, a saída exibirá linhas em branco. Os valores iniciais de quantity e output são valores vazios string.

Reserve um minuto para examinar a linha inicial do código que contém um elemento string de HTML.

const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";
Observe as marcas:<div>,<h2>,<span>e o código &trade; de símbolo contido na variável input.

Examine a saída desejada para a saída final do programa:

Output:
Quantity: 5000
Output: <h2>Widgets &reg;</h2><span>5000</span>


Comece a adicionar o código da solução ao código inicial sob o comentário // Your work here.

Defina a variável quantity para o valor obtido extraindo o texto entre as marcas <span> e </span>.

Defina a variável output com o valor de input, em seguida, remova as marcas <div> e </div>.

Substitua o caractere ™ HTML (&trade;) por ® (&reg;) na output variável.

Execute sua solução e verifique se a saída corresponde à saída esperada.

Output:
Quantity: 5000
Output: <h2>Widgets &reg;</h2><span>5000</span>


SOLUÇÃO:


const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here

// Extract the "quantity"
const string openSpan = "<span>";
const string closeSpan = "</span>";

int quantityStart = input.IndexOf(openSpan) + openSpan.Length; // + length of <span> so index at end of <span> tag
int quantityEnd= input.IndexOf(closeSpan);
int quantityLength = quantityEnd - quantityStart;
quantity = input.Substring(quantityStart, quantityLength);
quantity = $"Quantity: {quantity}";

// Set output to input, replacing the trademark symbol with the registered trademark symbol
const string tradeSymbol = "&trade;";
const string regSymbol = "&reg;";
output = input.Replace(tradeSymbol, regSymbol);

// Remove the opening <div> tag
const string openDiv = "<div>";
int divStart = output.IndexOf(openDiv);
output = output.Remove(divStart, openDiv.Length);

// Remove the closing </div> tag and add "Output:" to the beginning
const string closeDiv = "</div>";
int divCloseStart = output.IndexOf(closeDiv);
output = "Output: " + output.Remove(divCloseStart, closeDiv.Length);

Console.WriteLine(quantity);
Console.WriteLine(output);

*/


/*

Dependências:

Dependências são bibliotecas ou pacotes que um projeto precisa para funcionar corretamente. 
Elas podem ser gerenciadas por meio de ferramentas como NuGet, que facilitam a instalação, atualização e remoção de pacotes.

Comandos:

dotnet add package [nome-do-pacote] - Adiciona uma dependência ao projeto.
dotnet remove package [nome-do-pacote] - Remove uma dependência do projeto.
dotnet list package - Lista todas as dependências do projeto.
dotnet restore - Restaura as dependências do projeto, baixando os pacotes necessários.
dotnet list package --outdated - Lista as dependências desatualizadas do projeto, podendo atualizá-las posteriormente.
dotnet update package - Atualiza todas as dependências do projeto para a versão mais recente.
dotnet update package [nome-do-pacote] - Atualiza uma dependência específica para a versão mais recente.
dotnet list package --outdated --include-prerelease - Lista as dependências desatualizadas, incluindo versões pré-lançamento.
dotnet add package Humanizer --version 2.11.10 - Adiciona a dependência Humanizer na versão 2.11.10 ao projeto.
dotnet add package Humanizer - Adiciona a dependência Humanizer na versão mais recente
dotnet add package Humanizer --prerelease - Adiciona a dependência Humanizer, incluindo versões pré-lançamento.

*/