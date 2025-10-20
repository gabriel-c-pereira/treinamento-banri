# Expressões aritméticas

Expressões aritméticas são fundamentais na programação, pois permitem realizar cálculos e manipulações numéricas. Vamos explorar os operadores aritméticos em C#, como usá-los em expressões e alguns cuidados a serem tomados ao trabalhar com diferentes tipos de dados.

## O que são expressões aritméticas?
- Expressões aritméticas combinam números, variáveis e operadores para realizar cálculos matemáticos.
- Em C#, podemos usar os operadores aritméticos para somar, subtrair, multiplicar, dividir, e calcular o resto de uma divisão.

## Operadores aritméticos em C#

### Principais operadores:

- Adição `+`: Soma dois valores.

```csharp
int resultado = 5 + 3;  // Resultado: 8
```

- Subtração `-`: Subtrai um valor de outro.

```csharp
int resultado = 10 - 4;  // Resultado: 6
```

- Multiplicação `*`: Multiplica dois valores.

```csharp
int resultado = 6 * 3;  // Resultado: 18
```

- Divisão `/`: Divide um valor pelo outro.

> Importante: Na divisão entre dois inteiros, o resultado será um inteiro (a parte decimal é descartada).

```csharp
int resultado = 10 / 3;  // Resultado: 3 (parte decimal é ignorada)
double resultadoReal = 10.0 / 3.0;  // Resultado: 3.3333...
```

- Módulo `%`: Retorna o resto da divisão.

```csharp
int resto = 10 % 3;  // Resultado: 1
```

### Ordem de precedência

- A ordem das operações é semelhante à matemática tradicional: multiplicação e divisão têm prioridade sobre adição e subtração.
- Parênteses podem ser usados para alterar a ordem das operações.

```csharp
int resultado1 = 5 + 3 * 2;  // Resultado: 11 (Multiplicação é feita antes)
int resultado2 = (5 + 3) * 2;  // Resultado: 16 (Parênteses alteram a ordem)
```

### Trabalhando com diferentes tipos de dados

- Quando misturamos tipos diferentes, como inteiros `int` e números de ponto flutuante `double`, precisamos tomar cuidado com a precisão do resultado.

```csharp
int a = 10;
double b = 3.0;
double resultado = a / b;  // Resultado: 3.3333...
```

- Nesse caso, como `b` é um `double`, o resultado da divisão é convertido para `double`.

### Operadores de atribuição

- Podemos combinar operadores aritméticos com o operador de atribuição `=` para simplificar as operações.

```csharp
int numero = 5;

numero += 3;  // Equivale a: numero = numero + 3; Resultado: 8
numero -= 2;  // Equivale a: numero = numero - 2; Resultado: 6
numero *= 4;  // Equivale a: numero = numero * 4; Resultado: 24
numero /= 6;  // Equivale a: numero = numero / 6; Resultado: 4
numero %= 3;  // Equivale a: numero = numero % 3; Resultado: 1
```

### Incremento e decremento

- C# possui operadores especiais para incrementar ou decrementar o valor de uma variável.

Operadores:
- Incremento `++`: Adiciona 1 à variável.
- Decremento `--`: Subtrai 1 da variável.

```csharp
int numero = 5;

numero++;  // Equivale a: numero = numero + 1; Resultado: 6
numero--;  // Equivale a: numero = numero - 1; Resultado: 5
```

## Importante

- Expressões aritméticas são essenciais para cálculos e manipulações numéricas em programação.

- Compreender a ordem de precedência e como os diferentes tipos de dados interagem é fundamental para evitar erros.

- Praticar com operadores aritméticos ajuda a fixar esses conceitos e a aplicar operações matemáticas corretamente no código.

## Dicas adicionais:

- Sempre que estiver trabalhando com divisão, tenha atenção ao tipo de dados para evitar perder a precisão (use double ou decimal quando necessário).

- Utilize parênteses para controlar a ordem das operações e tornar seu código mais legível.

## [Exercícios](02-exercicios.md)