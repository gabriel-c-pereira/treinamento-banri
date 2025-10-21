# O que são estruturas de repetição

As estruturas de repetição (comumente chamadas de _loops_) permitem que um bloco de código seja executado várias vezes de acordo com uma condição específica. Em C#, existem três estruturas principais de repetição:

- `for`
- `while`
- `do`-`while`

## A estrutura `for`

O _loop_ `for` é usado quando sabemos de antemão quantas vezes queremos repetir um bloco de código. Ele é composto por três partes: a inicialização de uma variável, a condição de continuação e a atualização da variável.

Sintaxe:

```csharp
for (inicializacao; condicao; incremento/decremento)
{
    // Código a ser executado em loop (N vezes), enquanto a condição for verdadeira
}
```

- `inicializacao`: Geralmente são declaradas/inicializadas uma ou mais variáveis de controle para o loop — por exemplo: `int i = 0`;
- `condicao`: O loop continua enquanto a condição for verdadeira — por exemplo: `i < 10`;
- `incremento/decremento`: Após cada iteração (cada volta do loop), a variável (geralmente inicializada na inicialização e verificada na condição) é incrementada ou decrementada — por exemplo: `i++`.

Exemplo:

```csharp
for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"O valor de i é: {i}");
}
```

- Neste exemplo o loop começa com `i = 0` e continua enquanto `i` for menor que 10. A cada iteração (cada volta do loop), `i` é incrementado em 1. O valor de `i` é impresso em cada iteração — o loop vai ser executado 10 vezes, imprimindo os números de 0 a 9.

## A estrutura `while`

O _loop_ `while` é utilizado quando não sabemos exatamente quantas vezes o loop deve ser executado, mas continuamos enquanto uma condição for verdadeira.

Sintaxe:

```csharp
while (condicao)
{
    // Código a ser executado em loop (N vezes), enquanto a condição for verdadeira (condição é verificada primeiro — bloco é executado após)
}
```

- `condicao`: O loop continua enquanto a condição for verdadeira — por exemplo: `processamentoConcluido == false`;

Exemplo:

```csharp
bool processamentoConcluido = false;

while (processamentoConcluido == false) // ou !processamentoConcluido
{
    processamentoConcluido = ProcessarDados();
}
```

> Dica: Um bloco de código contido dentro de uma estrutura `while` pode nunca ser executado, se a condição já estiver não verdadeira na primeira verificação.

## A estrutura `do`-`while`

O _loop_ `do`-`while` é muito semelhante ao `while`, mas a principal diferença é que ele garante que o bloco de código seja executado **ao menos uma vez**, pois a condição é verificada **somente após cada execução**.

Sintaxe:

```csharp
do
{
    // Código a ser executado em loop (1 + N vezes), enquanto a condição for verdadeira (condição é verificada após — bloco é executado primeiro)
} while (condicao);
```

Exemplo:

```csharp
bool processamentoConcluido = false;

do
{
    processamentoConcluido = ProcessarDados();
} while (processamentoConcluido == false) // ou !processamentoConcluido
```

## Interrompendo _loops_ (`break` e `continue`)

Existem truques para se interromper uma iteração de um _loop_ ou mesmo cancelar a execução da estrutura de repetição completamente, através das seguintes instruções:

- `continue`: Interrompe a iteração atual e pula para a próxima, forçando uma nova verificação de condições;
- `break`: Interrompe completamente a execução da estrutura de repetição, forçando uma saída independente das condições de execução.

Exemplo:

```csharp
int contador = 1;

while (true) // Esse é um chamado loop infinito
{
    if (contador == 101)
        break; // Encerra completamente a execução do loop while quando i atingir o número 101
    
    if (contador % 2 == 0) // Checa se é um número par
    {
        contador++;

        continue; // Interrompe a iteração atual aqui e pula para a próxima
    }

    Console.WriteLine(contador); // Imprime se tiver passado pela checagem de número par, ou seja, aqui tem que imprimir só números ímpares

    contador++;
}
```

## [Exercícios](02-exercicios.md)
