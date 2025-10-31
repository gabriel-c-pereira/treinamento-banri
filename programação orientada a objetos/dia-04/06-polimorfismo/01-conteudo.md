# Polimorfismo

Significa literalmente o ato de “se tomar múltiplas formas”. É o pilar da programação orientada a objetos que permite que um mesmo método execute **comportamentos diferentes** dependendo do **objeto que o está chamando**.

Em C#, o polimorfismo é possibilitado principalmente através de **overriding** (sobrescrita) e **overloading** (sobrecarga).

## Overriding (Sobrescrita)

Se dá principalmente através do reaproveitamento da estruturação em hierarquia possibilitado pelo conceito de **herança**, onde um mesmo método pode assumir uma forma na classe base e outra forma em classes derivadas.

Usa as seguintes palavras-chave:

- Na classe base:
  - `virtual`: **Permite** que um método possa ser sobrescrito.
  - `abstract`: **Obriga** classes derivadas a implementarem o método.
- Nas classes derivadas:
  - `override`: Indica que o método está sobrescrevendo um comportamento herdado.

> Nota: Ao aplicar _overriding_, a **assinatura do método** (nome, parâmetros e tipo de retorno) deve ser **idêntica** à do método original.

Exemplo:

```csharp
public class EntregaEconomica
{
    public string NumeroPedido { get; set; }
    public decimal PesoKg { get; set; }

    public EntregaEconomica(string numeroPedido, decimal pesoKg)
    {
        NumeroPedido = numeroPedido;
        PesoKg = pesoKg;
    }

    // Método demarcado como "virtual" possibilitando overriding na cadeia de herança
    public virtual decimal CalcularFrete()
    {
        return PesoKg * 5.0;
    }

    // Método demarcado como "virtual" possibilitando overriding na cadeia de herança
    public virtual void ExibirInfo()
    {
        Console.WriteLine($"Pedido {NumeroPedido} - Peso: {PesoKg}kg - Frete: R$ {CalcularFrete():F2}");
    }
}

public class EntregaExpressa : EntregaEconomica
{
    public string RegiaoOrigem { get; }
    public string RegiaoDestino { get; }

    public EntregaExpressa(string numeroPedido, decimal pesoKg, string origem, string destino)
        : base(numeroPedido, pesoKg)
    {
        RegiaoOrigem = origem;
        RegiaoDestino = destino;
    }

    // Sobrescrita do método advindo da classe base, para aplicação de lógica própria
    public override decimal CalcularFrete()
    {
        decimal valorBase = PesoKg * 7.0;

        if (RegiaoOrigem != RegiaoDestino)
            valorBase += 10.0;

        return valorBase;
    }

    // Sobrescrita do método advindo da classe base, para aplicação de lógica própria
    public override void ExibirInfo()
    {
        Console.WriteLine($"Pedido {NumeroPedido} - Peso: {PesoKg}kg - Expressa entre ({RegiaoOrigem} e {RegiaoDestino}) - Frete: R$ {CalcularFrete():F2}");
    }
}
```

## Overloading (sobrecarga)

Acontece quando métodos com o mesmo nome, dentro da mesma classe, oferecem **variações de parâmetros em sua assinatura** — tipos, número ou ordem dos parâmetros. Neste caso não envolve **herança** diretamente, pois tudo pode ser feito dentro de uma mesma classe.

Exemplo:

```csharp
public class Funcionario
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Cargo { get; set; }

    /* Várias sobrecargas do método Cadastrar */

    public void Cadastrar(string nome, int idade, string cargo)
    {
        Nome = nome;
        Idade = idade;
        Cargo = cargo;

        Console.WriteLine($"Funcionário {Nome}, {Cargo}, {Idade} anos, cadastrado com sucesso!");
    }

    public void Cadastrar(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
        Cargo = "INDEFINIDO";
        
        Console.WriteLine($"Funcionário {Nome}, {Cargo}, {Idade} anos, cadastrado com sucesso!");
    }

    public void Cadastrar(string nome)
    {
        Nome = nome;
        Idade = 0;
        Cargo = "INDEFINIDO";
        
        Console.WriteLine($"Funcionário {Nome}, {Cargo}, {Idade} anos, cadastrado com sucesso!");
    }
    
    public void Cadastrar() 
    {
        Nome = "INDEFINIDO";
        Idade = 0;
        Cargo = "INDEFINIDO";

        Console.WriteLine($"Funcionário {Nome}, {Cargo}, {Idade} anos, cadastrado com sucesso!");
    }
}
```

Em certos casos, fazer _method chaining (encadeamento)_ também é uma prática bastante comum dentro da prática de sobrecarga:

```csharp
public class Funcionario
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Cargo { get; set; }

    public void Cadastrar(string nome, int idade, string cargo)
    {
        Nome = nome;
        Idade = idade;
        Cargo = cargo;

        Console.WriteLine($"Funcionário {Nome}, {Cargo}, {Idade} anos, cadastrado com sucesso!");
    }

    public void Cadastrar(string nome, int idade)
    {
        this.Cadastrar(nome, idade, "INDEFINIDO");
    }

    public void Cadastrar(string nome)
    {
        this.Cadastrar(nome, 0);
    }
    
    public void Cadastrar() 
    {
        this.Cadastrar("INDEFINIDO");
    }
}
```

### Polimorfismo em instanciação de objetos (métodos construtores)

O mesmo conceito de overloading se aplica aos **métodos construtores**, permitindo múltiplas formas de instanciar objetos de uma mesma classe — algo extremamente útil em sistemas com diferentes níveis de detalhamento. As regras são exatamente iguais às de métodos normais, inclusive com encadeamento também possível, usando somente o `this()`.

> Relembrando: Construtores não deixam de ser métodos, só que são métodos especiais que só executam na **inicialização** de um objeto, uma única vez.

```csharp
public class Funcionario
{
    public string Nome { get; private set; }
    public int Idade { get; private set; }
    public string Cargo { get; private set; }

    public Funcionario(string nome, int idade, string cargo)
    {
        Nome = nome;
        Idade = idade;
        Cargo = cargo;
    }

    public Funcionario(string nome, int idade)
    {
        this(nome, idade, "INDEFINIDO");
    }

    public Funcionario(string nome)
    {
        this(nome, 0);
    }
    
    public Funcionario() 
    {
        this("INDEFINIDO");
    }
}
```

## [Exercícios](02-exercicios.md)
