# Arrays e coleções

Antes de entrarmos no uso prático de arrays e coleções, é importante entender o que são as estruturas de dados e por que elas são fundamentais na programação.

Toda aplicação precisa armazenar, organizar e manipular informações — e as estruturas de dados são as ferramentas que usamos para isso.
Elas definem como os dados são guardados na memória e como podemos acessá-los de forma eficiente.

Um **array**, por exemplo, é uma das formas mais simples de armazenar dados: uma sequência _contígua (organizada lado a lado na memória)_ de elementos do mesmo tipo.
A partir dele surgem variações e estruturas mais sofisticadas, como: _vetores_, _matrizes_, _listas_, _dicionários_, _filas_, _pilhas_ e até _tensores_ (usados em inteligência artificial).
Cada uma dessas estruturas resolve um tipo de problema diferente: algumas são melhores para buscas rápidas, outras para inserções dinâmicas, outras para modelar relações entre dados, etc.

Em resumo: as estruturas de dados são a base da lógica de programação e da eficiência dos algoritmos — aprender a escolher e usar a estrutura certa é um passo essencial para pensar como um desenvolvedor.

## Arrays

Um array em C# é uma estrutura de dados basilar, que por característica contém **elementos de um único tipo**, armazenados de forma sequencial na memória. Eles geralmente têm tamanho fixo, ou seja, precisa-se definir o tamanho no momento da sua definição, e esse tamanho não pode ser alterado depois.

Exemplo:

```csharp
int[] numeros = new int[5]; // Array de inteiros com 5 posições (começando do índice 0 e indo até o índice 4 (5-1)) — sempre começa-se pelo índice zero
numeros[0] = 1;             // Atribuindo valor ao primeiro elemento — índice 0
numeros[4] = 2;             // Atribuindo valor ao último elemento — índice 4
```

Características principais:

- Tamanho fixo;
- Acesso aos elementos por índice/posição (zero-based);
- Boa performance quando o tamanho é conhecido e fixo;
- Elementos armazenados de forma contígua na memória, o que facilita a leitura sequencial pelo processador.

### Curiosidades sobre variações de arrays

#### Vetor

Um vetor é um array **unidimensional**, ou seja, uma única sequência de elementos. Ele é o tipo mais simples de array e pode ser imaginado como uma linha de valores. Cada elemento é acessado por um índice simples, denotado por algo que pode ser entendido como uma posição: `[posição]`.

Exemplo:

```csharp
int[] vetor = { 1, 2, 3, 4 }; // Essa é uma outra forma de inicializar um array já com tamanho e elementos conhecidos
int elementoPosicao3 = vetor[2];  // Lembre-se: o primeiro elemento está no índice 0, então vetor[2] acessa o número 3
```

#### Matriz

Uma matriz é um array **bidimensional**, ou seja, uma espécie de _plano cartesiano de elementos_. Pode ser equiparado com uma representação de linhas e colunas, como em uma tabela. Cada elemento é acessado por dois índices, denotados por algo que pode ser entendido como uma linha e uma coluna: `[linha, coluna]`.

Exemplo:

```csharp
int[,] matriz = new int[3, 5] // Inicializando com colchetes e uma vírgula, para indicar duas dimensões
{
//         Colunas ↓
    {  1,  2,  3,  4,  5 },
    {  6,  7,  8,  9, 10 }, // Linhas →
    { 11, 12, 13, 14, 15 }
};
int elementoLinha2Coluna3 = matriz[1, 2]; // Acessando a terceira coluna (índice 2) da segunda linha (índice 1)
```

#### Tensor

Um tensor é uma generalização de arrays para **três ou mais dimensões**. É muito usado em inteligência artificial e ciência de dados, pois permite representar estruturas mais complexas de dados numéricos, como imagens, sons e séries temporais. Cada vírgula adicionada aos colchetes adicionada mais uma dimensão ou "eixo" de elementos: `[eixo1, eixo2, eixo3, eixo4, ...]`.

Exemplo:

```csharp
int[,,,] imagens = new int[5, 4, 4, 3] // Tensor 4D: [imagem, linha, coluna, canal RGB] — 5 imagens, com 4x4 pixels por imagem
{
    // Imagem 1
    {
        { {12, 34, 56}, {78, 90, 12}, {34, 56, 78}, {90, 12, 34} },
        // Linha 2
        {
            {255, 128, 64},
            {64, 128, 255},
            {128, 255, 64},
            // Coluna 4
            { 
                  0, 
                200, 
                100 // Canal B 
            }
        },
        { {0, 0, 255}, {255, 255, 0}, {0, 0, 255}, {255, 255, 0} },
        { {0, 0, 255}, {255, 255, 0}, {0, 0, 255}, {255, 255, 0} }
    },
    { { {23, 45, 67}, {89, 101, 123}, {45, 67, 89}, {101, 123, 45} }, { {56, 78, 90}, {12, 34, 56}, {78, 90, 12}, {34, 56, 78} }, { {111, 222, 123}, {234, 45, 67}, {89, 12, 34}, {56, 78, 90} }, { {12, 34, 56}, {78, 90, 12}, {34, 56, 78}, {90, 12, 34} } },
    { { {123, 234, 45}, {67, 89, 101}, {112, 131, 41}, {51, 61, 71} }, { {21, 32, 43}, {54, 65, 76}, {87, 98, 109}, {210, 220, 230} }, { {15, 25, 35}, {45, 55, 65}, {75, 85, 95}, {105, 115, 125} }, { {135, 145, 155}, {165, 175, 185}, {195, 205, 215}, {225, 235, 245} } },
    // ... Até a imagem 5
};
// Acessando a primeira imagem (índice 0), no canal B — azul (índice 2) do pixel posicionado na quarta coluna (índice 3) da segunda linha (índice 1)
int pixelImagem1Linha2Coluna4CanalB = imagens[0, 1, 3, 2]; // Valor 100
```

## Coleções — introdução rápida

Em C#, as coleções são estruturas mais avançadas para trabalhar com conjuntos de dados. Em termos de relação com arrays, podemos pensar nas coleções como abstrações mais sofisticadas de arrays. Internamente, muitas dessas coleções usam arrays para armazenar seus elementos, mas já vêm com lógica pronta para resolver determinados problemas.
Ou seja, enquanto arrays são simples, estáticos e flexíveis apenas na indexação, as coleções fornecem comportamentos prontos e estruturados para diferentes cenários de manipulação de dados.

Coleções serão abordadas em profundidade mais à frente, mas neste momento pincelaremos rapidamente algumas das coleções genéricas mais usadas: _listas_, _dicionários_, _filas_, _pilhas_ e _conjuntos_. Cada uma com uma função específica para resolver um problema específico.

### Listas (`List<T>`)

Uma coleção mais flexível, do tipo `List<T>`, que permite armazenar elementos de um mesmo tipo e **redimensionar automaticamente conforme a necessidade**.

> Nota: `<T>` em C# é uma **denotação de tipo genérico** (esse recurso será abordado em detalhes mais à frente) — neste momento, entenda que `T` representa um tipo que será definido na hora do uso da lista (definindo por exemplo `T` para `int`).

Exemplo:

```csharp
List<int> numeros = new List<int>(); // T aqui é int, ou seja, lista de inteiros
numeros.Add(1);                      // Adicionando o número 1
numeros.Add(2);                      // Adicionando o número 2

int numero2 = numeros[1];
```

### Dicionários (`Dictionary<TKey, TValue>`)

Em termos simples, um dicionário é uma coleção que permite associar **pares de chave e valor**. Isso pode ser imaginado como um catálogo ou uma lista telefônica, onde cada chave/identificação corresponde a um valor.

> Nota: `<TKey, TValue>` segue a mesma ideia do `<T>` mencionado acima, ou seja, concluímos que **denotações de tipos genéricos** podem ser feitas com qualquer representação — ex.: `T`, `TKey`, `TValue`, `Tipo`, `A`, `B`, `ZIndex`, `Etc`, ou qualquer denotação de sua escolha... `T` só é mais comumente usado por convenção.

Exemplo:

```csharp
Dictionary<string, int> agenda = new Dictionary<string, int>(); // Aqui TKey é string e TValue é int
agenda.Add("John Doe", 32444554);                               // Adicionando a chave "John Doe" com o número de telefone 32444554
agenda.Add("Mary Doe", 35554424);                               // Adicionando a chave "Mary Doe" com o número de telefone 35554424
agenda.Add("Jake Monroe", 33542244);                            // Adicionando a chave "Jake Monroe" com o número de telefone 33542244

int numeroMary = agenda["Mary Doe"];
```

### Filas (`Queue<T>`)

Filas são coleções baseadas no padrão **FIFO** — (First In... First Out), o que significa que o primeiro elemento que entra é o primeiro a sair. Ludicamente podemos pensar em uma fila de banco, supermercado ou cinema, onde a primeira pessoa a entrar na fila é a primeira a ser atendida (ordem de chegada).

Exemplo:

```csharp
Queue<string> filaPessoas = new Queue<string>(); // T aqui é string, ou seja, fila de strings (pessoas)
filaPessoas.Enqueue("Mary Doe");                 // Primeira pessoa enfileirada: "Mary Doe"
filaPessoas.Enqueue("Jake Monroe");              // Segundo pessoa enfileirada: "Jake Monroe"

string proximoAtendido = filaPessoas.Dequeue();  // Próximo atendido será "Mary Doe"
```

### Pilhas (`Stack<T>`)

Pilhas são coleções baseadas no padrão **LIFO** — (Last In, First Out), o que significa que o último elemento que entra é o primeiro a sair. Ludicamente, podemos pensar em uma pilha vertical de pratos ou livros, onde o último item a ser colocado será o primeiro a ser retirado.

Exemplo:

```csharp
Stack<string> pilhaLivros = new Stack<string>(); // T aqui é string, ou seja, pilha de strings (livros)
pilhaLivros.Push("Hamlet");                      // Primeiro livro empilhado: "Hamlet"
pilhaLivros.Push("O Príncipe");                  // Segundo livro empilhado: "O Príncipe"
pilhaLivros.Push("Dom Quixote");                 // Terceiro livro empilhado: "Dom Quixote"

string proximoLivro = pilhaLivros.Pop();         // Próximo livro a ser pego será "Dom Quixote"
```

### Conjuntos (`HashSet<T>`)

Conjuntos são coleções que **não permitem elementos duplicados** e não garantem uma ordem específica de armazenamento, diferentemente de listas, que permitem duplicatas e ordenam conforme indicação do usuário.

Exemplo:

```csharp
HashSet<string> tags = new HashSet<string>(); // T aqui é string, ou seja, conjunto de tags
tags.Add("C#");                               // Adicionando a tag "C#"
tags.Add("Programação");                      // Adicionando a tag "Programação"
tags.Add("HashSet");                          // Adicionando a tag "HashSet"
tags.Add("C#");                               // Tentativa de adicionar duplicata — será ignorada

bool contemCSharp = tags.Contains("C#");      // Verificação da existência da tag "C#" no conjunto será true
bool contemJava = tags.Contains("Java");      // Verificação da existência da tag "Java" no conjunto será false
```

## [Exercícios](02-exercicios.md)
