# Encapsulamento

O **encapsulamento** é um dos pilares da Programação Orientada a Objetos (POO). Seu objetivo é **proteger os dados de um objeto** contra acessos ou modificações indevidas, expondo apenas o que realmente precisa ser acessado externamente.

Em termos práticos, ele se refere ao **ocultamento de informações** (_information hiding_), garantindo que detalhes internos de implementação fiquem invisíveis para quem utiliza a classe.

## Conceito

Algumas definições importantes:

- Encapsulamento também é um processo de **abstração de complexidades**, ou seja, esconder os detalhes internos de um objeto que não são relevantes para o seu consumidor;
- É um **princípio de design**, no qual cada componente de um programa deve expor apenas o necessário;
- Oferece **proteção adicional aos dados**, evitando modificações diretas e indevidas.

Pense em uma **cápsula de remédio**: Você sabe que o remédio serve para tratar um dado problema, mas **não tem acesso direto à fórmula** — apenas à cápsula segura. O encapsulamento no código funciona da mesma forma: ele protege o conteúdo interno e oferece uma interface controlada de acesso aos dados.

## Encapsulamento com métodos de acesso (getters e setters)

Vamos analisar esse código problemático:

```csharp
public class ContaCorrente
{
    public string Cpf;

    public ContaCorrente(string cpf) {
        Cpf = cpf;
    }
}

class Program
{
    static void Main()
    {
        var conta = new ContaCorrente("014.254.456-78");
        
        conta.Cpf = "952.679.958-60"; // Acesso direto à propriedade, permitindo alteração indiscriminada do CPF.

        Console.WriteLine(conta.Cpf); // Imprime "952.679.958-60".
    }
}
```

Em termos de negócio, geralmente após uma conta corrente aberta, não faria sentido se ter uma alteração de CPF dado que CPFs não mudam para pessoas, assim como contas correntes também não mudam de titular geralmente.

Uma melhor abordagem para proteger o CPF de alterações seria então, usar Getter público e Setter privado, para garantir que o objeto mantenha a devida consistência conforme as regras de negócio estabelecidas:

```csharp
public class ContaCorrente
{
    private string _cpf;

    public ContaCorrente(string cpf) {
        _cpf = cpf;
    }

    public string GetCpf() // Método getter
    {
        return _cpf;
    }

    /* Aqui o método setter está comentado e não será usado nesse objeto — mas um setter poderia de fato ser implementado caso uma regra de negócio exigisse troca de CPF sob alguma circunstância. */
    // public void SetCpf(string novoCpf)
    // {
    //     Validações [...]
    // 
    //     _cpf = novoCpf;
    // }
}

class Program
{
    static void Main()
    {
        var conta = new ContaCorrente("014.254.456-78");
        
        // conta._cpf = "952.679.958-60"; // Ocasiona erro no build, pois _cpf não é acessível nesse contexto.

        // Console.WriteLine(conta._cpf); // Ocasiona erro no build, pois _cpf não é acessível nesse contexto.

        Console.WriteLine(conta.GetCpf()); // Imprime "014.254.456-78".
    }
}
```

### Getters e setters na sintaxe C\#

Os métodos getter e setter tem uma sintaxe especial, agregada às propriedades:

```csharp
public class ContaCorrente
{
    public string Cpf { get; private set; } // Método getter com "public" implícito e método setter privado

    public ContaCorrente(string cpf)
    {
        Cpf = cpf;
    }
}

class Program
{
    static void Main()
    {
        var conta = new ContaCorrente("014.254.456-78");

        // conta.Cpf = "952.679.958-60"; // Ocasiona erro no build, pois o "set" de Cpf não é acessível nesse contexto.

        Console.WriteLine(conta.Cpf); // Imprime "014.254.456-78", pois o "get" está acessível.
    }
}
```

`get` e `set`, apesar de não parecerem, são métodos, que tem **uma implementação padrão implícita**. Observando o código acima é como se esses métodos tivessem as seguintes implementações padrão:

```csharp
private string _cpf;

public string Cpf { get; set; }

string get() {
    return _cpf;
}

void set(string novoCpf) {
    _cpf = novoCpf;
}
```

porém, com a implementação simplificada `{ get; set; }` nada disso fica visível, embora seu mecanismo esteja funcional.

Isso também significa que nos métodos `get` e `set` é possível de se adicionar corpos de funções, para agregar funcionalidades extras (ex.: validações):

```csharp
public class ContaCorrente
{
    private string _cpf;

    public string Cpf
    {
        // Método getter com "corpo".
        get 
        { 
            return _cpf; 
        } 
        
        // Método setter com "corpo".
        set 
        {
            if (string.IsNullOrWhiteSpace(value)) // "value" é o parâmetro de entrada padrão do método especial "setter" do C#
                _cpf = "000.000.000-00";

            if (value.Length != 14)
                _cpf = "000.000.000-00";

            _cpf = value;
        }
    }

    public ContaCorrente(string cpf)
    {
        Cpf = cpf;
    }
}

class Program
{
    static void Main()
    {
        var conta = new ContaCorrente("014.254.456-78");

        // conta.Cpf = " "; // Agora o "set" de Cpf está acessível, e passará por validação.

        Console.WriteLine(conta.Cpf); // Como o "set" anterior era inválido de acordo com as regras implementadas, agora imprime "000.000.000-00".
    }
}
```

> Dica: Também é possível implementar um comportamento **read-only** em propriedades, setando somente o `get` e omitindo o `set`:
>
> ```csharp
> public string Cpf { get; }
> ```
>
> Com isso, a propriedade Cpf poderá ser alterada somente durante a execução do seu método construtor.

## Diferença entre abstração e encapsulamento

| Pilar | Foco |
| :-: | - |  
| **Abstração** | Define **o que** um objeto faz de forma mais geral, a respeito da sua separação de responsabilidades, características e comportamentos. |
| **Encapsulamento** | Controla **como** se podem acessar características de um objeto. |

## [Exercícios](02-exercicios.md)
