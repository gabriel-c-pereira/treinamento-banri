# A estrutura condicional ternária `?:`

O `if` ternário (`?:`) em C# é uma maneira simplificada de escrever expressões condicionais, usando menos linhas de código que o `if-else` tradicional. Ele é útil quando você precisa atribuir um valor ou tomar uma decisão com base em uma única condição.

Sintaxe:

```csharp
condicao 
    ? /* Código a ser executado se a condição for verdadeira */ 
    : /* Código a ser executado se a condição for não verdadeira */;
```

### Exemplo:

Suponha que você deseja verificar se uma pessoa é maior de idade (18 anos ou mais). Tradicionalmente, isso seria feito com um `if-else`:

```csharp
int idade = 18;
string resultado;

if (idade >= 18)
{
    resultado = "Você é maior de idade.";
} else {
    resultado = "Você NÃO é maior de idade.";
}

Console.WriteLine(resultado);
```

Com o operador ternário, você consegue escrever o mesmo código de forma mais compacta:

```csharp
int idade = 18;
string resultado;

resultado = idade >= 18 
    ? "Você é maior de idade." : "Você NÃO é maior de idade.";

Console.WriteLine(resultado);
```

- Neste exemplo, o programa verifica se a variável `idade` é maior ou igual a 18:
  - Se for, a string "Você é maior de idade." (porção à esquerda do `:`) será usada;
  - Se não for, a string "Você NÃO é maior de idade." (porção à direita do `:`) será usada.

## Quando usar

- Quando a decisão a ser tomada for simples e couber em uma linha sem prejudicar a expressividade do código, principalmente em casos em que a decisão resultará em atribuição de valor a uma variável.

## Quando não usar

- Se a condição ou as ações a serem tomadas forem complicadas, o `if` ternário pode tornar o código difícil de compreender. Nesse caso, usar `if-else` seria mais expressivo.

## [Exercícios](02-exercicios.md)
