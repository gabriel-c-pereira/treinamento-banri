# O que é tipagem de dados?

Tipagem de dados é a forma como uma linguagem de programação define e trabalha com diferentes tipos de dados (como números, texto, booleanos, objetos, etc.).

## O que é uma linguagem fortemente tipada?

Linguagens fortemente tipadas "forçam" a tipagem da variável na sua declaração, ou seja, uma vez que é definido o tipo de uma variável, ele não poderá mudar posteriormente. Isso torna o código mais seguro e mais instrumentado, auxiliando mais no trabalho do desenvolvedor e evitando erros, já que o compilador tem mais poder para verificar operações inválidas com base nos tipos de variáveis definidos.

C# é fortemente tipado, logo, toda variável precisa ter um tipo específico definido quando é declarada, como `int`, `string`, `bool`, `Object`, `byte[]` etc.

Uso de `var` implica em _tipagem por inferência_, mas a tipagem também é definida/concluída na declaração.

```csharp
int numero = 0;
numero = 10;  // Funciona normalmente.
numero = "avião";  // Resulta em erro de compilação (build time), pois está se tentando atribuir um texto a uma variável numérica.
```

## Tipos de dados em C#

Em C#, os tipos de dados são divididos principalmente em dois grupos: tipos primitivos (ou tipos simples) e tipos complexos (ou tipos de referência).

### 1. Tipos primitivos (valor)

Estes são alguns dos tipos que o C# oferece que **são armazenados diretamente na memória stack**.

- Bit/Booleano (`bool`):
    - Representação do bit (ligado/desligado) através dos valores literais _false_ ou _true_.
        ```csharp
        bool cadastroAtivo = true; // Armazena uma representação de 1 bit (curiosidade: consome 8 bits de memória)
        ```
- Números inteiros:
    - `byte`: Números inteiros entre 0 e 255 (sem sinal).
        ```csharp
        byte nivel = 200; // Inteiro de 8 bits de memória
        ```
    - `short`: Números inteiros entre -32.768 e 32.767.
        ```csharp
        short ano = 2025; // Inteiro de 16 bits de memória
        ```
    - `int`: Números inteiros entre -2.147.483.648 e 2.147.483.647.
        ```csharp
        int pontosJogador = 15000; // Inteiro de 32 bits de memória
        ```
    - `long`: Números inteiros entre -9.223.372.036.854.775.808 e 9.223.372.036.854.775.807.
        ```csharp
        long populacaoMundial = 8000000000; // Inteiro de 64 bits de memória
        ```
- Números com ponto flutuante:
    - `float`: Aproximadamente 7 dígitos de precisão.
        - Declarado explicitamente com o sufixo `f`.
        ```csharp
        float temperatura = 36.6f; // Ponto flutuante de 32 bits de memória
        ```
    - `double`: Aproximadamente 15 a 16 dígitos de precisão.
        ```csharp
        double distanciaTerraLua = 384400.5; // Ponto flutuante de 64 bits de memória
        ```
    - `decimal`: Aproximadamente 28 a 29 dígitos de precisão. Usado em finanças ou em cálculos de alta precisão.
        - Declarado explicitamente com o sufixo `m`.
        ```csharp
        decimal precoBitcoin = 123456.78m; // Ponto flutuante de 128 bits de memória (alta precisão)
        ```
- Caractere textual (`char`):
    - Um (e somente um) caractere _Unicode BMP_ válido.
        ```csharp
        char inicialNome = 'J'; // Equivalente a um short de 16 bits de memória (UTF-16)
        char numero = '5';
        char simbolo = '@';
        char espaco = ' ';
        ```

### 2. Tipos complexos (referência)

Estes são tipos **armazenados na memória heap e referenciados através da memória stack**.

- Arrays:
    - Uma coleção de elementos de um mesmo tipo.
        ```csharp
        int[] numeros = { 1, 2, 3, 4, 5 };  // Array de inteiros
        ```  
- Objetos (Instâncias de classes):
    - Representação de qualquer conjunto complexo de informações.
        ```csharp
        class Cliente
        {
            public string Nome;
            public int Idade;
            public bool CadastroAtivo;
        }

        static void Main()
        {
            Cliente novoCliente = new Cliente();

            novoCliente.Nome = "John Doe";
            novoCliente.Idade = 30;
            novoCliente.CadastroAtivo = true;
        }
        ```
        > Nota: Atributos, mesmo que tipados com tipos primitivos, também ficam junto ao seu objeto na memória heap.

### 3. Mas e o tipo textual `string`?

Este é um tipo especial, que na prática tem a maior base dos seus comportamentos como um tipo complexo, mas por design, tem sintaxe de tipo primitivo.

- Cadeia de caracteres textuais (`string`):
    - Sequência de caracteres _Unicode_ válidos.
        ```csharp
        string nome = "John Doe"; // N bits (variável a depender do tamanho)
        string senha = "abc123$%";
        string mensagem = "Olá, mundo!";
        ```

## Conversão de tipos

Apesar de C# ser uma linguagem fortemente tipada, é possível de se fazer conversão de tipos:

### 1. Conversão implícita (automática)

Quando não há risco de perda de dados.

```csharp
int numero = 10;

long numeroLongo = numero; // Conversão implícita de int para long, pois int "cabe" naturalmente dentro de long
double valor = numero; // Conversão implícita de int para double, pois int "cabe" dentro de double como um valor de decimal zerada inicialmente
```

### 2. Conversão explícita

Quando existe o risco de perda de dados e/ou os tipos em questão não são compatíveis, **demandando atenção explícita do desenvolvedor na operação**.

#### Casting sintático

Sintaxe específica para indicar a intenção de mudança de tipo.

```csharp
double valor = 9.8;

int numero = (int)valor;  // A porção decimal de double não tem função dentro de um int, logo, é necessária a declaração de intencionalidade da perda da parte decimal através do casting explícito
```  

#### Casting com métodos "built-in"

O próprio C# oferece uma gama de métodos de conversão através, por exemplo, do objeto `System.Convert`.

```csharp
string textoNumerico = "123";

int numero = System.Convert.ToInt32(textoNumerico);  // Intencionalidade também clara, através de um método "buit-in"
```  

## [Exercícios](02-exercicios.md)
