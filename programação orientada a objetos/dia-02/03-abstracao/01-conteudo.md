# Abstração

A **abstração** é um dos pilares da programação orientada a objetos. Ela consiste em representar um conceito do mundo real dentro do software, **omitindo detalhes desnecessários** e **mantendo apenas o essencial**.

Em C#, podemos aplicar abstração com **classes concretas**, **classes abstratas** e **interfaces**, conforme o nível de generalização que queremos alcançar.

## Recapitulando: Representação direta

Começamos com uma classe simples, que **espelha diretamente o mundo real**, mas **sem ocultar detalhes internos**.

```csharp
public class Pix {
    public string CpfOriginador;
    public string CpfDestinatario;
    public double Valor;

    public string Executar() {
        if (!ValidadorCPF.IsValid(CpfOriginador))
            return "Originador inválido!";

        if (!ValidadorCPF.IsValid(CpfDestinatario))
            return "Destinatário inválido!";

        if (Valor <= 0)
            return "Valor do pix deve ser um valor positivo!";

        return $"Pix de R$ {Valor:F2} enviado de {CpfOriginador} para {CpfDestinatario}.";
    }

    public void ImprimirComprovante() {
        Console.WriteLine($"Pix de R$ {Valor:F2} enviado de {CpfOriginador} para {CpfDestinatario}.");
    }
}
```

Nessa versão tudo é público, e qualquer parte do código poderia alterar `originador`, `destinatário` ou mesmo `valor`, depois de o pix ter sido criado.

## Classes concretas

Aqui começamos a **esconder os dados internos** e expor apenas **métodos controlados**, que representam o comportamento essencial de `Pix`.

```csharp
public class Pix {
    private string _cpfOriginador;
    private string _cpfDestinatario;
    private double _valor;

    public Pix(string cpfOriginador, string cpfDestinatario, double valor) {
        _cpfOriginador = cpfOriginador;
        _cpfDestinatario = cpfDestinatario;
        _valor = valor;
    }

    public string Executar() {
        if (!ValidadorCPF.IsValid(_cpfOriginador))
            return "Originador inválido!";

        if (!ValidadorCPF.IsValid(_cpfDestinatario))
            return "Destinatário inválido!";
        
        if (_valor <= 0)
            return "Valor do pix deve ser um valor positivo!";

        return $"Pix de R$ {_valor:F2} enviado de {_cpfOriginador} para {_cpfDestinatario}.";
    }

    public void ImprimirComprovante() {
        Console.WriteLine($"Pix de R$ {_valor:F2} enviado de {_cpfOriginador} para {_cpfDestinatario}.");
    }
}
```

Agora, o uso da classe é mais simples e seguro — quem cria o `Pix` não precisa (e nem deve) alterar os detalhes internos (como `originador`, `destinatário` e `valor`) depois do pix criado. Essa é a **primeira forma concreta de aplicar abstração**.

Essa classe funciona para o objetivo de abstração de complexidades, mas não diferencia **tipos diferentes de `Pix`**.

## Classes abstratas

Quando queremos **definir uma estrutura base**, mas permitir que **as classes consumidoras alterem partes específicas**, usamos **classes abstratas**, com o uso da palavra chave `abstract` na classe e nos métodos necessários, utilizando `override` na hora de "especializar" esses métodos.

Por exemplo, caso trabalhássemos com diferentes tipos de pix (pessoa física e pessoa jurídica):

```csharp
public abstract class Pix { // Note o "abstract"
    protected string _idOriginador;
    protected string _idDestinatario;
    protected double _valor;

    // Definição de um método "abstrato", ou seja, sem "corpo", a ser implementado por quem "consumir" a classe abstrata
    public abstract string Executar(); // Note o "abstract"

    public void ImprimirComprovante() {
        Console.WriteLine($"Pix de R$ {_valor:F2} enviado de {_idOriginador} para {_idDestinatario}.");
    }
}

public class PixPessoaFisica : Pix { // PixPessoaFisica está "herdando" de Pix
    public PixPessoaFisica(string cpfOriginador, string cpfDestinatario, double valor) {
        _idOriginador = cpfOriginador;
        _idDestinatario = cpfDestinatario;
        _valor = valor;
    }
    
    public override string Executar() { // Note o "override", especializando o método "abstract" definido na classe abstrata Pix
        if (!ValidadorCPF.IsValid(_idOriginador))
            return "Originador inválido!";

        if (!ValidadorCPF.IsValid(_idDestinatario))
            return "Destinatário inválido!";
        
        if (_valor <= 0)
            return "Valor do pix deve ser um valor positivo!";

        return $"Pix de R$ {_valor:F2} enviado de {_idOriginador} para {_idDestinatario}.";
    }

    // ImprimirComprovante() existe implicitamente aqui, pois a classe abstrata Pix o declarou
}

public class PixPessoaJuridica : Pix { // PixPessoaJuridica também está "consumindo" (ou "herdando de") Pix
    public PixPessoaJuridica(string cnpjOriginador, string cnpjDestinatario, double valor) {
        _idOriginador = cnpjOriginador;
        _idDestinatario = cnpjDestinatario;
        _valor = valor;
    }
    
    public override string Executar() { // Note o "override", especializando o método "abstract" definido na classe abstrata Pix
        if (!ValidadorCNPJ.IsValid(_idOriginador))
            return "Originador inválido!";

        if (!ValidadorCNPJ.IsValid(_idDestinatario))
            return "Destinatário inválido!";
        
        if (_valor <= 0)
            return "Valor do pix deve ser um valor positivo!";

        return $"Pix de R$ {_valor:F2} enviado de {_idOriginador} para {_idDestinatario}.";
    }

    // ImprimirComprovante() existe implicitamente aqui, pois a classe abstrata Pix o declarou
}
```

Aqui, a classe `Pix` passou a ser uma entidade abstrata, que não pode ser instanciado diretamente, porém, garante que **classes consumidoras possuam um método `ImprimirComprovante()` e precisem obrigatoriamente implementar um método `Executar()`**.

## Classes de contrato — *interfaces*

Agora, vamos supor que mesmo o método `ImprimirComprovante()` deveria ser implementado em cada classe "consumidora", e que **nada deveria ser já implementado na classe "base"**. Em alguns casos vai fazer mais sentido a implementação de um **contrato**, que vai, na prática, **ditar a exigência de como as classes implementantes devem "se comportar"**.  

Para contratos, usamos `interface`:

```csharp
public interface IPix { // O uso do prefixo "I" antes do nome da interface é uma convenção comum em C#
    // Definição dos métodos de contrato, também sem "corpo", só ditando como devem ser implementados por quem "consumir" a interface
    string Executar();
    void ImprimirComprovante();
}

public class PixPessoaFisica : IPix { // PixPessoaFisica está "consumindo" (ou "implementando") IPix
    private string _cpfOriginador;
    private string _cpfDestinatario;
    private double _valor;

    public PixPessoaFisica(string cpfOriginador, string cpfDestinatario, double valor) {
        _cpfOriginador = cpfOriginador;
        _cpfDestinatario = cpfDestinatario;
        _valor = valor;
    }

    public string Executar() {
        if (!ValidadorCPF.IsValid(_cpfOriginador))
            return "Originador inválido!";

        if (!ValidadorCPF.IsValid(_cpfDestinatario))
            return "Destinatário inválido!";
        
        if (_valor <= 0)
            return "Valor do pix deve ser um valor positivo!";

        return $"Pix de R$ {_valor:F2} enviado da pessoa {_cpfOriginador} para a pessoa {_cpfDestinatario}.";
    }

    public void ImprimirComprovante() {
        Console.WriteLine($"Pix de R$ {_valor:F2} enviado da pessoa {_cpfOriginador} para a pessoa {_cpfDestinatario}.");
    }
}

public class PixPessoaJuridica : IPix { // PixPessoaJuridica também está "consumindo" (ou "implementando") IPix
    public PixPessoaJuridica(string cnpjOriginador, string cnpjDestinatario, double valor) {
        _cnpjOriginador = cnpjOriginador;
        _cnpjDestinatario = cnpjDestinatario;
        _valor = valor;
    }
    
    public override string Executar() {
        if (!ValidadorCNPJ.IsValid(_cnpjOriginador))
            return "Originador inválido!";

        if (!ValidadorCNPJ.IsValid(_cnpjDestinatario))
            return "Destinatário inválido!";
        
        if (_valor <= 0)
            return "Valor do pix deve ser um valor positivo!";

        return $"Pix de R$ {_valor:F2} enviado da empresa {_cnpjOriginador} para a empresa {_cnpjDestinatario}.";
    }

    public void ImprimirComprovante() {
        Console.WriteLine($"Pix de R$ {_valor:F2} enviado da empresa {_cnpjOriginador} para a empresa {_cnpjDestinatario}.");
    }
}
```

## [Exercícios](02-exercicios.md)
