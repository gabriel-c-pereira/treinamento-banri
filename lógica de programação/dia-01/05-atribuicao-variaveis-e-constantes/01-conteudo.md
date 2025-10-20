# Variáveis

## O que são variáveis?

Uma variável é como uma "caixa" que armazena informações (dados) na memória do computador.

Em C#, uma variável tem:

- **Tipo**: Define o tipo de dado que ela pode armazenar (inteiro, texto, decimal, etc.).

- **Nome**: Uma identificação que você escolhe para referenciar essa variável no código.

Pense nela como um "rótulo" que você coloca em uma posição na memória do computador para guardar valores.

### Declaração e Inicialização

**Declaração**: É quando você diz ao computador que quer reservar um espaço na memória para armazenar um valor.

**Inicialização**: É quando você atribui um valor à variável.

```csharp
// Declaração de variáveis
int idade;
string nome;

// Inicialização das variáveis
idade = 25;
nome = "Joana";

// Declaração e inicialização ao mesmo tempo
double saldo = 3000.50;
```

### Explicação:

`int idade;` cria uma variável do tipo inteiro chamada idade.</br>
`string nome;` cria uma variável do tipo texto (string) chamada nome.

Depois, essas variáveis são inicializadas com valores (`idade = 25;` e `nome = "Maria";`).

`double salario = 3000.50;` é um exemplo de declaração e inicialização na mesma linha.

# Atribuição

A atribuição é quando você dá um valor para a variável usando o operador de atribuição `=`. A expressão à direita do `=` é calculada e armazenada na variável à esquerda.

```csharp
int a = 10;  // Atribuindo o valor 10 à variável 'a'
int b = 5;   // Atribuindo o valor 5 à variável 'b'

int soma = a + b;  // Atribuindo à variável 'soma' o resultado da soma de 'a' e 'b'
soma = soma + 2;   // Atualizando o valor de 'soma' para o valor atual mais 2
```

### Explicação

`soma = a + b;` pega o valor de a (10) e b (5), soma os dois e armazena o resultado (15) na variável soma.</br>
`soma = soma + 2;` pega o valor atual de soma (15), adiciona 2 e atualiza soma para 17.

### Observações:

A atribuição sempre ocorre da direita para a esquerda. O valor do lado direito é calculado e atribuído ao lado esquerdo.
O valor da variável pode ser atualizado quantas vezes for necessário.

# Constantes

Uma constante é semelhante a uma variável, mas, após ser definida, seu valor não pode ser alterado.

Útil para representar valores que não mudam, como o valor de PI (3.14), ou um valor máximo fixo em um sistema.

#### Declaração de Constantes em C#:

Use a palavra-chave `const` para declarar uma constante.
O valor da constante deve ser atribuído no momento da declaração.

```csharp
const double PI = 3.14159;
const int ANO_DE_NASCIMENTO = 1990;
```

#### Explicação

`const double PI = 3.14159;` cria uma constante chamada `PI` do tipo `double` e atribui o valor 3.14159. Esse valor não pode ser mudado depois.</br>
Tentar atribuir um novo valor a uma constante resultará em erro.

# Curiosidades

Em C# você consegue criar variáveis como constantes, criando ela como somente leitura, desta forma você consegue inicializar ela com um valor de fora da classe a partir do construtor.

```csharp
using System;

class Programa
{
    static void Main()
    {
        var valorExemplo = "exemplo";

        var exemploClasse = new ExemploReadOnly(valorExemplo);

        Console.WriteLine($"Valor do exemplo: {exemploClasse.Exemplo}");

        exemploClasse.Exemplo = "novo valor"; // Aqui vai dar erro, pois você não consegue alterar valores de propriedades somente leitura, somente em tempo de construção
    }
}

public class ExemploReadOnly{
    
    public readonly string Exemplo;

    public ExemploReadOnly(string valorExemplo){
        this.exemplo = valorExemplo;
    }
}
```

# [Exercícios](02-exercicios.md)
