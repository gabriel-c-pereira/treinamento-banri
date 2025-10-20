# Expressões lógicas

## O que são expressões lógicas

Expressões lógicas são utilizadas em programação para tomar decisões com base em condições. Essas expressões retornam valores booleanos (`true` ou `false`) e são usadas principalmente em estruturas condicionais, como `if`, `else`, `while`, e `for`. Em C#, as expressões lógicas são construídas usando operadores lógicos para combinar ou inverter condições.

## Como funcionam as expressões lógicas

Em C#, expressões lógicas são criadas usando operadores lógicos, que permitem combinar várias condições para tomar decisões mais complexas. Os principais operadores lógicos em C# são:

- `&&` (E lógico)
- `||` (OU lógico)
- `!` (NÃO lógico)

### Operador `&&` (E lógico)

O operador `&&` retorna `true` apenas se todas as condições forem verdadeiras. Se qualquer uma das condições não for verdadeira, ele retorna `false`.

Sintaxe:

```csharp
bool resultado = condicao1 && condicao2 // Resultado será true se ambas as condições forem verdadeiras
```

Exemplo:

```csharp
int idade = 20;
bool temHabilitacao = true;

bool podeDirigir = idade >= 18 && temHabilitacao == true;
```

- No exemplo acima, o programa verifica se a pessoa tem 18 anos ou mais **e** se tem habilitação. Apenas se ambas as condições forem verdadeiras, o marcador podeDirigir será `true`.

### Operador `||` (OU lógico)

O operador `||` retorna `true` se pelo menos uma das condições for verdadeira. Ele só retorna `false` se todas as condições forem não verdadeiras.

Sintaxe:

```csharp
bool resultado = condicao1 || condicao2 // Resultado será true se pelo menos uma das condições for verdadeira
```

Exemplo:

```csharp
bool temIngresso = false;
bool nomeNaListaVip = true;

bool acessoLiberado = temIngresso || nomeNaListaVip;
```

- No exemplo acima, o programa verifica se a pessoa adquiriu um ingresso **ou** se está na lista VIP. Em qualquer um dos casos, se verdadeiro, o marcador acessoLiberado será `true`.

### Operador `!` (NÃO lógico)

O operador `!` (também conhecido como _NOT_) é usado para inverter o valor de uma variável ou verificar invertido em uma expressão. Se verdadeiro, ele transforma em não verdadeiro, e vice-versa.

Sintaxe:

```csharp
bool resultado = !condicao // Resultado será o inverso do valor que estiver na condição
```

Exemplos:

```csharp
bool portaAberta = true;

portaAberta = !portaAberta; // portaAberta = false

portaAberta = !portaAberta; // portaAberta = true
```

- No exemplo acima, o programa está apenas invertendo o valor da variável, que começou como `true`, foi invertida para `false`, e novamente invertida para `true`.

```csharp
bool usuarioBloqueado = true;

bool podeAcessar = !usuarioBloqueado;
```

- No exemplo acima, o programa verifica se o usuário está ou não bloqueado. Devido à inversão da expressão no teste, se ele não estiver bloqueado, o marcador podeAcessar será `true`.

> Curiosidade: Operadores `!` podem ser encadeados. Ex.: `!!` ou `!!!`.

## Combinação de operadores lógicos

Operadores lógicos podem ser combinados para formar expressões mais complexas, utilizando parênteses para definir a _ordem de precedência_ de avaliação.

Exemplo:

```csharp
int idade = 20;
bool temIngresso = false;
bool nomeNaListaVip = true;

bool acessoLiberado = idade >= 16 && (temIngresso || nomeNaListaVip);
```

- No exemplo acima, o programa verifica se a pessoa tem 16 anos ou mais, e se adquiriu um ingresso ou está na lista VIP. Se a pessoa tiver 16 anos ou mais e atender a pelo menos uma das outras condições, acessoLiberado será `true`.

> Dica: Os parênteses garantem que `temIngresso || nomeNaListaVip` seja avaliado antes de aplicar o `&&` com `idade >= 16`, assegurando que a lógica reflita corretamente a condição de acesso.

Resumindo

- `&&` (E lógico): Todas as condições precisam ser verdadeiras para a expressão ser `true`.
- `||` (OU lógico): Pelo menos uma condição precisa ser verdadeira para a expressão ser `true`.
- `!` (NÃO lógico): Inverte atribuição de valores e condições.

## [Exercícios](02-exercicios.md)
