# Anatomia de uma classe C\#

## Atributos

Correspondem às características (também podem ser chamados de "dados" ou "informações").
Como vimos anteriormente, na classe `ExtratoBancario` possivelmente existiria um atributo chamado `NomePessoa`, que poderia armazenar o nome da pessoa que está requisitando aquele extrato.

```csharp
public class ExtratoBancario {
    public string NomePessoa;
}
```

## Métodos

Correspondem aos comportamentos que a instância do objeto daquela classe pode executar. No caso de `ExtratoBancario`, um método `CalcularSaldo` poderia representar um comportamento da classe.

```csharp
public class ExtratoBancario {
    public string NomePessoa;

    public double CalcularSaldo() {
        double total = // Algoritmo/Lógica: Percorrer todas as movimentações, somando depósitos e subtraindo saques.
        
        return total;
    }
}
```

## Instanciação

A **instanciação** é o momento em que um **objeto é criado a partir de uma classe**. Esse processo acontece com a palavra-chave `new`.

Por exemplo, ao instanciar um novo `ExtratoBancario`, o código abaixo cria um **objeto vivo/real na memória**:

```csharp
public class Program {  
    public static void Main() {
        // Criação (instanciação) de um novo objeto da classe ExtratoBancario  
        ExtratoBancario extratoCarlos = new ExtratoBancario("123.456.789-00");

        // A partir daqui, o objeto "extratoCarlos" pode chamar métodos da classe  
        double saldoAtual = extratoCarlos.CalcularSaldo();
    
        Console.WriteLine($"Saldo atual de {extratoCarlos.NomePessoa}: R$ {saldoAtual:F2}");  
    }  
}
```

Por quê estamos passando um CPF dentro de `ExtratoBancario("123.456.789-00")`, como se a classe fosse um método que recebe parâmetros? Vamos falar sobre construtores.

## Construtores

O construtor também é um método, mas é um **método especial**, que é o primeiro a ser chamado durante a **fase de instanciação** de uma classe. Ou seja, quando você cria um novo (`new`) objeto `ExtratoBancario` para "Carlos", o método construtor é o primeiro a ser executado:

```csharp
public class ExtratoBancario {
    public string NomePessoa;

    public ExtratoBancario(string cpf) {
        this.NomePessoa = // Algoritmo/Lógica: Busca o nome da pessoa através do seu CPF na base da receita federal
    }

    public double CalcularSaldo() {
        /* */
    }
}
```

Em C#, o **método construtor leva o mesmo nome da classe** e **não possui nenhum tipo de especificação de retorno (nem void)**.

Quando um construtor não é explicitamente definido na classe, assume-se obrigatoriamente a **existência implícita** de um **construtor vazio**, ou seja, que não recebe nenhum parâmetro e não faz nenhuma ação relevante para o estado do objeto durante a fase de instanciação.

```csharp
public class ExtratoBancario {
    public string NomePessoa;

    // Quando não é definido explicitamente o construtor, um construtor "escondido" ficará definido pelo C# com essa "assinatura".
    /*
     * public ExtratoBancario() 
     * {
     *
     * }
    */
    
    public double CalcularSaldo() {
        /* */
    }
}
```

A ausência de um construtor explícito (e consequente existência do construtor implícito vazio) acarretaria em uma única opção possível de instanciação de `ExtratoBancario`:

```csharp
public class Program {  
    public static void Main() {
        ExtratoBancario extratoCarlos = new ExtratoBancario(); // Note a não passagem de nenhum parâmetro agora, se passássemos CPF, o sistema apresentaria erro
    }  
}
```

Uma classe pode ter também **dois ou mais construtores**, desde que cada um tenha uma **assinatura diferente** — ou seja, uma configuração diferente de parâmetros:

```csharp
public class ExtratoBancario {
    public string NomePessoa;

    public ExtratoBancario() {
        this.NomePessoa = "Anônimo";
    }

    public ExtratoBancario(string cpf) {
        this.NomePessoa = // Algoritmo/Lógica: Busca o nome da pessoa através do seu CPF na base da receita federal
    }

    public double CalcularSaldo() {
        /* */
    }
}
```

Assim, no momento da instanciação, o construtor executado dependerá da **forma como o objeto é criado**:

```csharp
public class Program {  
    public static void Main() {
        // Criação (instanciação) de um novo objeto da classe ExtratoBancario através do construtor que recebe um parâmetro CPF
        ExtratoBancario extratoCarlos = new ExtratoBancario("123.456.789-00");

        // Criação (instanciação) de um novo objeto da classe ExtratoBancario através do construtor sem parâmetros
        ExtratoBancario extratoAnonimo = new ExtratoBancario();
    }  
}
```

Essa técnica é bastante útil para oferecer **flexibilidade na criação de objetos**, permitindo que diferentes cenários de inicialização sejam atendidos.

E quanto a essa nova palavra chave `public` contida tanto na classe, quanto nos atributos, e métodos (inclusive construtores)? Vamos falar sobre os controles de visibilidade.

## Controles de visibilidade

Visibilidade define **como e onde** os membros de uma classe podem ser acessados.
Em outras palavras, ela controla o nível de proteção e exposição de um objeto para quem acessa de fora da classe.

As principais visibilidades utilizadas em C# são:

| Acessibilidade <br/> (da mais permissiva para a menos) | Significado |
| :-: | - |
| `public`              | O acesso é possível de **qualquer parte da solução (solution)**. |
| `protected`           | O acesso é possível **apenas pela classe e suas classes derivadas na solução** (veremos mais sobre classes derivadas no conteúdo de **herança**). |
| `internal`            | O acesso é possível **pela classe e todas as demais dentro do mesmo assembly/projeto** (ou seja, dentro do mesmo "pacote" compilado). |
| `protected` `internal`| Combinação de acesso possível **na classe, em suas classes derivadas na solução, e todas as demais dentro do mesmo assembly/projeto**. |
| `protected` `private` | Combinação de acesso possível **na classe e em suas classes derivadas dentro do mesmo assembly/projeto**. |
| `private`             | O acesso é possível **apenas pela classe**. |

> Notas:
>
> - Quando não é definido explicitamente um modificador de acesso em atributos e métodos, o padrão é `private`;
> - Quando não é definido explicitamente um modificador de acesso a nível de classes, o padrão é `internal`
>   - Em classes, só é possível de se utilizar `internal` ou `public`.

Exemplo:

```csharp
public class ExtratoBancario { // acessível em todos os lugares.
    private string cpfPessoa; // acessível somente interno ao seu escopo (nesse caso, a classe).
    protected string NomePessoa; // acessível somente no seu escopo e nos escopos das classes herdeiras.

    public ExtratoBancario() { // acessível em todos os lugares.
        /* */
    }

    public ExtratoBancario(string cpf) { // acessível em todos os lugares.
        /* */
    }

    public double CalcularSaldo() { // acessível em todos os lugares.
        /* */
    }
}
```

## [Exercícios](02-exercicios.md)
