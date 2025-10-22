# Classes, características e comportamentos em C\#

## O que afinal é uma classe?

Uma **classe** é uma estrutura que serve como **modelo** para agrupar **características** e **comportamentos** relacionadas a um mesmo tipo de objeto.

Em C#, usamos classes para definir **como algo deve ser representado no código** — ou seja, **o que ele tem** e **o que ele faz**.

## Características e comportamentos

- **Características**: São as informações (variáveis) que descrevem algo. Em uma classe, essas informações são chamadas de **atributos** ou **campos**.  
- **Comportamentos**: São as ações (funções) que podem ser executados. Em uma classe, essas ações são chamadas de **métodos**.

Exemplo de definição:

```csharp
class ContaCorrente
{
    static decimal saldo; // Característica (informação — atributo)

    static void Depositar(decimal valor) // Comportamento (ação — método)
    {
        saldo += valor;
    }
}
```

Exemplo de utilização:

```csharp
class App
{
    static void Main()
    {
        // Atribuindo um valor à característica saldo da classe ContaCorrente
        ContaCorrente.saldo = 500.00m;

        // Executando o comportamento Depositar da classe ContaCorrente
        ContaCorrente.Depositar(250.00m);

        Console.WriteLine($"Saldo final: {ContaCorrente.saldo}");
    }
}
```

## Nota sobre o uso de `static`

Usar membros **estáticos** através da instrução `static` é uma forma de fazer uso direto da classe como um simples agrupador, mas adentrando em _orientação a objetos_, vamos perceber que não é a única forma de trabalhar com classes. Veremos mais à frente recursos de classes mais voltados para _orientação a objetos_.

## [Exercícios](02-exercicios.md)
