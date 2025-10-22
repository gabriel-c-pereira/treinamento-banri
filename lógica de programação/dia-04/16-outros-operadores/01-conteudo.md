# Outros operadores — introdução rápida

Além dos operadores básicos já explorados, o C# possui outros operadores que são importantes para ações como manipulação de bits e verificação de tipos de dados.

## Operadores bit a bit

> Lembre-se: Tudo em computação, no final, são bits, então todos os tipos representados no C#, no fim são transformados em longas sequências de 0s e 1s. O porém é que também é possível trabalhar de forma literal com representações em bits no c# através do prefixo `0b`.
> Exemplo:
>
> ```csharp
> int numero10 = 0b1010;  // representação binária do número 10
> ```

Os seguintes operadores trabalham diretamente nos **bits** dos valores inteiros (`byte`, `short`, `int`, `long`, etc.):

-------------------------------------------
| Operador | Significado                  |
| -------- | ---------------------------- |
| `&`      | E bit a bit                  |
| `\|`     | OU bit a bit                 |
| `^`      | XOU (OU exclusivo) bit a bit |
| `~`      | NÃO bit a bit (inversão)     |
| `<<`     | Deslocamento à esquerda      |
| `>>`     | Deslocamento à direita       |
-------------------------------------------

### E bit a bit (`&`)

O operador `&` realiza a operação E em cada bit correspondente de dois inteiros. Somente resulta em `1` ao final se **ambos os bits forem `1`**, senão o resultado é `0`.

Exemplo:

```csharp
int numero10 = 0b1010;  // representação binária simplificada do inteiro 10
int numero12 = 0b1100;  // representação binária simplificada do inteiro 12

int resultado = numero10 & numero12; // Aplicando um E binário, o resultado simplificado é 0b1000 (inteiro 8)
Console.WriteLine($"{resultado}");   // 8
```

### OU bit a bit (`|`)

O operador `|` realiza a operação OU em cada bit correspondente de dois inteiros. Resulta em `1` se **pelo menos um dos bits for `1`**, senão o resultado é `0`.

Exemplo:

```csharp
int numero10 = 0b1010;  // representação binária simplificada do inteiro 10
int numero12 = 0b1100;  // representação binária simplificada do inteiro 12

int resultado = numero10 | numero12; // Aplicando um OU binário, o resultado simplificado é 0b1110 (inteiro 14)
Console.WriteLine($"{resultado}");   // 14
```

### XOU bit a bit (`^`)

O operador `^` realiza a operação XOU (ou OU exclusivo) em cada bit correspondente. Resulta em `1` somente se os bits forem diferentes um do outro, senão o resultado é `0`.

Exemplo:

```csharp
int numero10 = 0b1010;  // representação binária simplificada do inteiro 10
int numero12 = 0b1100;  // representação binária simplificada do inteiro 12

int resultado = numero10 ^ numero12; // Aplicando um XOU binário, o resultado simplificado é 0b0110 (inteiro 6)
Console.WriteLine($"{resultado}");   // 6
```

### NÃO bit a bit (`~`)

O operador `~`, de forma semelhante ao NÃO lógico, realiza também inversão, mas nesse caso a nível de todos os bits de um valor.

Exemplo:

```csharp
int numero10 = 0b00000000000000000000000000001010;  // representação binária completa do inteiro 10

int resultado = ~numero10; // Aplicando um NÃO binário, o resultado completo é 0b11111111111111111111111111110101 (inteiro -11)
Console.WriteLine($"{resultado}");   // -11
```

### Deslocamento à esquerda (`<<`)

O operador `<<` desloca todos os bits para a esquerda **N vezes**, preenchendo os bits _menos significativos_ com zeros. Cada deslocamento equivale a **multiplicar por 2**.

Sintaxe:

```csharp
resultado = valor << N; // Valor tem seus bits deslocados N vezes para a esquerda
```

Exemplo:

```csharp
int numero10 = 0b00000000000000000000000000001010;  // representação binária completa do inteiro 10

int resultado = numero10 << 1; // Aplicando 1 deslocamento à esquerda, o resultado completo é 0b00000000000000000000000000010100 (inteiro 20)
Console.WriteLine($"{resultado}");   // 20
```

### Deslocamento à direita (`>>`)

O operador `>>` desloca todos os bits para a direita **N vezes**, preenchendo os bits _mais significativos_ com zeros. Cada deslocamento equivale a **dividir por 2**.

Sintaxe:

```csharp
resultado = valor >> N; // Valor tem seus bits deslocados N vezes para a direita
```

Exemplo:

```csharp
int numero10 = 0b00000000000000000000000000001010;  // representação binária completa do inteiro 10

int resultado = numero10 >> 1; // Aplicando 1 deslocamento à direita, o resultado completo é 0b00000000000000000000000000000101 (inteiro 5)
Console.WriteLine($"{resultado}");   // 5
```

## Operadores de tipos

### Checagem de tipo (`is`)

O operador `is` verifica se um objeto é de um tipo específico, retornando `true` ou `false`.

Exemplo:

```csharp
object mensagem = "Olá mundo";

bool variavelDoTipoInt = mensagem is int;       // false
bool variavelDoTipoString = mensagem is string; // true
```

### Conversão segura (`as`)

O operador `as` tenta converter um objeto para um tipo específico. Se a conversão falhar, retorna `null` ao invés de lançar exceção.

Exemplo:

```csharp
object mensagem = "Olá mundo";

int? variavelInt = mensagem as int;         // null — conversão inválida
bool variavelString = mensagem as string;   // "Olá mundo"
```

> Dica: Acrescentar `?` na declaração de variáveis serve para definir um dado tipo como _nulável_ (apto a receber `null`). Objetos complexos e strings são _nuláveis_ por padrão (abordaremos isso mais à frente).

## [Exercícios](02-exercicios.md)
