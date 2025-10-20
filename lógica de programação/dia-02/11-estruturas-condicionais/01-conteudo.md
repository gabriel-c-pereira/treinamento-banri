# O que são condicionais

Condicionais são estruturas essenciais na programação que permitem tomar decisões com base em certas condições. Em C#, usamos condicionais para executar diferentes blocos de código dependendo do resultado de expressões que geralmente envolvem operadores de comparação e lógicos.

## O que são condicionais?

Condicionais são usadas para alterar o fluxo do programa com base em condições especificadas. Em C#, as principais estruturas condicionais são:

- `if`
- `else if`
- `else`
- `switch`

### A estrutura `if`

A estrutura `if` é a mais básica e comum das condicionais. Ela verifica se uma condição é verdadeira e, se for, executa o bloco de código associado a essa condição.

Sintaxe:

```csharp
if (condicao)
{
    // Código a ser executado se a condição for verdadeira
}
```

Exemplo:

```csharp
int idade = 18;

if (idade >= 18)
{
    Console.WriteLine("Você é maior de idade.");
}
```

- Neste exemplo, o programa verifica se a variável idade é maior ou igual a 18. Se for, a mensagem "Você é maior de idade." é exibida.

### A estrutura `else`

O `else` é usado para especificar um bloco de código a ser executado quando a condição do `if` é não verdadeira.

Sintaxe:

```csharp
if (condicao)
{
    // Código se a condição for verdadeira
}
else
{
    // Código se a condição não for verdadeira
}
```

Exemplo:

```csharp
int idade = 16;

if (idade >= 18)
{
    Console.WriteLine("Você é maior de idade.");
}
else
{
    Console.WriteLine("Você é menor de idade.");
}
```

- Aqui, se idade for menor que 18, o bloco dentro do else é executado.

### A estrutura `else if`

O `else if` permite testar várias condições em sequência. Ele é útil quando temos várias opções a considerar.

Sintaxe:

```csharp
if (condicao1)
{
    // Código se condicao1 for verdadeira
}
else if (condicao2)
{
    // Código se condicao2 for verdadeira
}
else
{
    // Código se nenhuma das condições anteriores for verdadeira
}
```

Exemplo:

```csharp
int nota = 85;

if (nota >= 90)
{
    Console.WriteLine("Nota A");
}
else if (nota >= 80)
{
    Console.WriteLine("Nota B");
}
else if (nota >= 70)
{
    Console.WriteLine("Nota C");
}
else
{
    Console.WriteLine("Nota abaixo de C");
}
```

- O programa avalia as condições em sequência e executa o bloco de código da primeira condição verdadeira. Se nenhuma for verdadeira, o bloco dentro do `else` é executado.

### A estrutura `switch`

A estrutura `switch` é uma alternativa ao `if-else` quando se deseja comparar uma mesma variável com vários valores diferentes. É particularmente útil para tornar o código mais organizado quando há muitas condições específicas.

Sintaxe:

```csharp
switch (variavel)
{
    case valor1:
        // Código a ser executado se variavel == valor1
        break;
    case valor2:
        // Código a ser executado se variavel == valor2
        break;
    default:
        // Código a ser executado se nenhuma das condições anteriores for atendida
        break;
}
```

Exemplo:

```csharp
int diaDaSemana = 3;

switch (diaDaSemana)
{
    case 1:
        Console.WriteLine("Domingo");
        break;
    case 2:
        Console.WriteLine("Segunda-feira");
        break;
    case 3:
        Console.WriteLine("Terça-feira");
        break;
    case 4:
        Console.WriteLine("Quarta-feira");
        break;
    case 5:
        Console.WriteLine("Quinta-feira");
        break;
    case 6:
        Console.WriteLine("Sexta-feira");
        break;
    case 7:
        Console.WriteLine("Sábado");
        break;
    default:
        Console.WriteLine("Dia inválido");
        break;
}
```

- Neste exemplo, a variável `diaDaSemana` é comparada com vários valores possíveis. O bloco de código correspondente ao valor é executado, e o `break` encerra a execução do `switch`. O `default` é uma cláusula opcional que é executada se nenhum dos casos corresponder ao valor da variável.

## [Exercícios](02-exercicios.md)
