# Trabalhando com strings em C#

Nesta aula, vamos explorar como trabalhar com strings em C#. Strings são essenciais em qualquer aplicação, pois representam sequências de caracteres, como nomes, mensagens, e textos em geral.

## O que é uma string?

- Em C#, uma string é um tipo de dado que armazena uma sequência de caracteres.
- Strings são representadas com aspas duplas ``"`` e podem conter letras, números, espaços e caracteres especiais.

```csharp
string saudacao = "Olá, mundo!";
```

## Declaração e inicialização de strings

- Você pode declarar e inicializar uma string da seguinte maneira:

```csharp
string nome = "Maria";
string mensagem = "Bem-vindo(a) ao sistema!";
```

- Strings também podem ser declaradas sem inicialização e receber valor posteriormente:

```csharp
string descricao;
descricao = "Descrição do produto";
```

## Concatenando strings

- Concatenar strings significa juntar duas ou mais strings em uma única sequência.

Usando o operador `+`:

```csharp
string nome = "João";
string saudacao = "Olá, " + nome + "!";  // Resultado: "Olá, João!"
```

Usando `string.Concat`:

```csharp
string nome = "João";
string saudacao = string.Concat("Olá, ", nome, "!"); // Resultado: "Olá, João!"
```

Interpolação de Strings `$`:

- Uma forma mais legível e prática de concatenar strings.

```csharp
string nome = "João";
string saudacao = $"Olá, {nome}!";  // Resultado: "Olá, João!"
```

- A interpolação de strings `$` permite inserir variáveis diretamente dentro das `{}` no texto.

## Métodos úteis para trabalhar com strings

C# oferece muitos métodos para manipular strings. Vamos ver alguns dos 
mais úteis:

1. `Length`: Retorna o comprimento (número de caracteres) da string.
```csharp
string nome = "João";
int comprimento = nome.Length;  // Resultado: 4
```

2. `ToUpper` e `ToLower`:

- `ToUpper`: Converte a string para maiúsculas.
- `ToLower`: Converte a string para minúsculas.

```csharp
string saudacao = "Olá, Mundo!";
string maiuscula = saudacao.ToUpper();  // Resultado: "OLÁ, MUNDO!"
string minuscula = saudacao.ToLower();  // Resultado: "olá, mundo!"
```

3. `Substring`:

- Extrai uma parte da string, informando a posição inicial e, opcionalmente, o número de caracteres.

```csharp
string frase = "C# é incrível!";
string parte = frase.Substring(3, 2);  // Resultado: "é "
```

4. `Replace`:

- Substitui uma parte específica da string por outra.

```csharp
string saudacao = "Olá, João!";
string novaSaudacao = saudacao.Replace("João", "Maria");  // Resultado: "Olá, Maria!"
```

5. `Trim`, `TrimStart` e `TrimEnd`:

- `Trim`: Remove espaços em branco do início e do fim da string.
- `TrimStart`: Remove espaços do início.
- `TrimEnd`: Remove espaços do fim

```csharp
string texto = "  C# é incrível!  ";
string textoSemEspacos = texto.Trim();  // Resultado: "C# é incrível!"
```

6. `Contains`:

- Verifica se a string contém uma sequência específica de caracteres.

```csharp
string frase = "Aprender C# é divertido!";
bool contem = frase.Contains("C#");  // Resultado: true
```

## Quebra de Linha e Caracteres Especiais

- Para incluir uma quebra de linha em uma string, use `\n` ou `Environment.NewLine`.
- Para incluir uma tabulação, use `\t`.

```csharp
string texto = "Primeira linha.\nSegunda linha.";
Console.WriteLine(texto);

/* Resultado:
Primeira linha.
Segunda linha.
*/
```

## Strings literais verbatim `@`

- Usando `@` antes das aspas, você pode escrever strings com múltiplas linhas e caracteres especiais, como barras invertidas `\`, sem a necessidade de escape.

```csharp
string caminhoArquivo = @"C:\Users\NomeDoUsuario\Documentos\arquivo.txt";
```

## Comparação de strings

- Você pode comparar strings usando o operador `==` ou o método `.Equals`.

```csharp
string palavra1 = "C#";
string palavra2 = "C#";

bool iguais = palavra1 == palavra2;  // Resultado: true
bool iguaisComMetodo = palavra1.Equals(palavra2);  // Resultado: true
```

### Importante:

Strings são uma parte fundamental de qualquer programa. Saber manipular strings permite criar aplicativos mais interativos e funcionais.

Existem muitos métodos para trabalhar com strings em C#. Pratique com diferentes métodos para entender como cada um funciona

## [Exercícios](02-exercicios.md)