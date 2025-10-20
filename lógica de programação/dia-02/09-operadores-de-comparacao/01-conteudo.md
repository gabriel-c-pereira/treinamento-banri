# Operadores de comparação

## O que são operadores de comparação

Operadores de comparação são usados em programação para comparar valores, variáveis ou expressões. Eles são fundamentais quando precisamos tomar decisões no código, como verificar se um número é maior que outro, se dois valores são iguais, ou se uma condição específica é verdadeira. Em C#, esses operadores retornam um valor booleano (`true` ou `false`), que é utilizado para controlar o fluxo do programa.

## Como funcionam os operadores de comparação

Os operadores de comparação em C# permitem verificar relações entre dois valores, como igualdade, diferença, maior ou menor, entre outros. Aqui está uma lista dos operadores de comparação em C# e como eles funcionam:

### Igual `==`

- Compara dois valores para verificar se são iguais.

- Retorna `true` se os valores forem iguais, caso contrário, retorna `false`.

```csharp
int a = 5;
int b = 5;
bool resultado = (a == b);  // Resultado: true
```

### Diferente de `!=`

- Verifica se dois valores são diferentes.

- Retorna `true` se os valores não forem iguais.

```csharp
int a = 5;
int b = 3;
bool resultado = (a != b);  // Resultado: true
```

### Maior que `>`

- Verifica se o valor à esquerda é maior que o valor à direita.

- Retorna `true` se o valor à esquerda for maior.

```csharp
int a = 10;
int b = 5;
bool resultado = (a > b);  // Resultado: true
```

### Menor que `<`

- Verifica se o valor à esquerda é menor que o valor à direita.

- Retorna `true` se o valor à esquerda for menor.

```csharp
int a = 4;
int b = 7;
bool resultado = (a < b);  // Resultado: true
```

### Maior ou igual a `>=`

- Verifica se o valor à esquerda é maior ou igual ao valor à direita.

- Retorna `true` se for maior ou igual.

```csharp
int a = 10;
int b = 10;
bool resultado = (a >= b);  // Resultado: true
```

### Menor ou igual a `<=`

- Verifica se o valor à esquerda é menor ou igual ao valor à direita.

- Retorna `true` se for menor ou igual.

```csharp
int a = 5;
int b = 10;
bool resultado = (a <= b);  // Resultado: true
```

## Comparação com diferentes tipos de dados

Os operadores de comparação podem ser usados com diversos tipos de dados, incluindo:

- Números inteiros `int`, números de ponto flutuante `double`, caracteres `char`, e até mesmo `strings`.

Comparação de Strings:

Ao comparar strings com o operador `==`, C# faz uma comparação sensível a maiúsculas e minúsculas.

```csharp
string nome1 = "Alice";
string nome2 = "alice";
bool resultado = (nome1 == nome2);  // Resultado: false
```

## [Exercícios](02-exercicios.md)