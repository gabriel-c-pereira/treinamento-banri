# Escopos, funções e métodos em C\#

## Escopo

Um escopo define a região do código onde uma variável é acessível. Em C#, existem diferentes níveis de escopo, que determinam a visibilidade das variáveis e objetos dentro do programa. Os principais tipos de escopo são:

- Escopo de classe: Variáveis definidas dentro de uma classe, mas fora de qualquer método, são acessíveis por todos os métodos dessa classe.
- Escopo de método: Variáveis definidas dentro de um método são acessíveis apenas dentro daquele método.
- Escopo de bloco de código: Variáveis definidas dentro de blocos (normalmente delimitados por abre e fecha chaves `{ }`) só são acessíveis dentro desses blocos.

Exemplo de escopo em C#:

```csharp
using System;

class App // Classe — aqui denominada "App", mas pode ter qualquer nome
{
    // Constante localizada no escopo de classe — poderá ser acessada desse escopo "para dentro"
    const string PREFIXO = "9";

    static void Main() // Método — aqui denominado "Main", mas pode ter qualquer nome. A palavra reservada "static" será abordada futuramente
    {
        // Variável localizada no escopo do método — poderá ser acessada desse escopo "para dentro". Note que essa variável já não está acessível no escopo "de fora" do método
        string ddd = "51";

        if (ddd.Equals("51"))
        {
            // Variável localizada no escopo do bloco if — poderá ser acessada desse escopo "para dentro". Note que essa variável não é acessível fora desse escopo (nem no else if, que é outro bloco isolado)
            string numeroPrivado = "9999-9991";

            Console.WriteLine($"({ddd}) {PREFIXO}{numeroPrivado}");  // O número completo de telefone é acessível apenas dentro desse bloco
        } else if (ddd.Equals("0800")) {
            string numeroPublico = "999-991";

            // Console.WriteLine($"({ddd}) {PREFIXO}{numeroPrivado}");  // Erro
            Console.WriteLine($"({ddd}) {PREFIXO}{numeroPublico}");
        }

        // Console.WriteLine($"({ddd}) {PREFIXO}{numeroPrivado}"); // Erro
        // Console.WriteLine($"({ddd}) {PREFIXO}{numeroPublico}"); // Erro
    }
}
```

Recapitulando:

- `PREFIXO`: É acessível em qualquer lugar dentro da classe `App`;
- `ddd`: É acessível em qualquer lugar dentro do método `Main`;
- `numeroPrivado`: É acessível apenas dentro do bloco `if`;
- `numeroPublico`: É acessível apenas dentro do bloco `else if`.

## Funções e métodos

Funções e métodos são formas de delimitar e tornar determinadas tarefas mais específicas. Seria como "quebrar" em partes o código, separando blocos para solução de problemas menores, e que juntos, solucionam um problema maior.

### Qual a diferença entre função e método?

Funções normalmente são associadas a linguagens de programação mais procedurais, enquanto métodos são associados a classes, que são comumente utilizadas em linguagens de programação _orientadas a objetos_. C#, apesar de permitir vários estilos de programação, é essencialmente orientado a objetos, então o mais indicado é se usar o termo **"método"**.

### Então, novamente, o que é um método?

Um método é uma forma de agrupar código que realiza uma tarefa específica, de forma a resolver um problema menor. Métodos podem receber dados (comumente chamados **parâmetros**) e podem ou não retornar dados ao chamador (comumente referido como **retorno**).

Estrutura básica de um método em C#:

```csharp
tipoRetorno NomeMetodo(tipoParametro nomeParametro1, tipoParametro nomeParametro2, ...) // Nenhum ou quantos forem necessários
{
    // [Algoritmo...]
    
    return valor; // Se método é "void", return é opcional, senão é obrigatório
}
```

- `tipoRetorno`: O tipo de dado que o método retornará (`int`, `string`, `bool`, etc.) — `void` é a forma especial de indicar que o método não tem retorno;
- `NomeMetodo`: O nome que identifica o método, que será a forma de usá-lo em outros trechos do código;
- `tipoParametro1`/`tipoParametro2`: Os tipos dos parâmetros que o método recebe;
- `nomeParametro1`/`nomeParametro2`: Os nomes que identificam os parâmetros que o método recebe, que serão a forma de usá-los no _corpo_ do método;
- `return`: Usado principalmente em casos de especificação de um tipo válido de retorno.

> Dica: Procure sempre nomear métodos e parâmetros (assim como qualquer variável) da forma mais descritiva possível, de forma que expresse claramente sua responsabilidade.

### Métodos com retorno

Métodos que retornam um valor precisam especificar o tipo de retorno e usar a instrução `return` para devolver o dado ao chamador.

Exemplo de método com retorno:

```csharp
using System;

class App
{
    static int Somar(int primeiraParcela, int segundaParcela)
    {
        int soma = primeiraParcela + segundaParcela;

        return soma; // o retorno esperado é int, e a variável soma é int

        // return primeiraParcela + segundaParcela // Também funciona
    }

    static void Main() // Método Main é sempre o principal (sempre ele é o método chamado pelo runtime na inicialização do programa)
    {
        int resultado = Somar(5, 3); // Chamando o método Somar
        
        Console.WriteLine($"O resultado da soma é: {resultado}");
    }
}
```

- `Somar`: Método que recebe dois parâmetros (`primeiraParcela` e `segundaParcela`) e retorna a o resultado da soma (`int`) deles;
- `Main`: Também é um método, sem retorno e sem parâmetros (nesse caso), chamado automaticamente no início do programa:
  - O método `Main` chama o método `Somar` para executar a operação, passando os valores 5 e 3 como **argumentos** para preencherem os **parâmetros** do método `Somar`;
  - O método `Main` aguarda a conclusão do método `Somar`, e recebe na variável `resultado` o retorno (`return`) do método `Somar`.

### Métodos sem retorno

São métodos que não retornam um valor para o chamador. São declarados com o tipo de retorno `void`.

Exemplo de método com retorno:

```csharp
using System;

class App
{
    static void ExibirMensagem(string mensagem) // Note o "void" no cabeçalho (também chamado de assinatura) deste método
    {
        Console.WriteLine(mensagem);

        // Não há return aqui
    }

    static void Main() // Método Main é sempre o principal (sempre ele é o método chamado pelo runtime na inicialização do programa)
    {
        ExibirMensagem("Olá mundo!"); // Não há uma variável recebendo valores do método aqui, só a sua chamada isolada
    }
}
```

- `ExibirMensagem`: Método que recebe um parâmetro (`mensagem`) e não retorna nada, pois tem finalidade de executar uma operação isolada e sem resultado ao chamador;
- `Main`: Também é um método, sem retorno e sem parâmetros (nesse caso), chamado automaticamente no início do programa:
  - O método `Main` chama o método `ExibirMensagem` para executar a operação, passando a string "Olá mundo!" como **argumento** para preencher o **parâmetro** do método `ExibirMensagem`;
  - Não há valor esperado, logo não há variável a se guardar algum dado de retorno.

## [Exercícios](02-exercicios.md)
