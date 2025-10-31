// 1. Conta bancária simples

using System;

public class ContaBancaria
{
    private static int contadorContas = 10000; // Contador para gerar números únicos de conta

    // Propriedades encapsuladas
    public int Numero { get; } // Somente leitura
    public string Cpf { get; } // Somente leitura
    public string Titular { get; } // Somente leitura
    public decimal Saldo { get; private set; } // Leitura pública, alteração apenas via métodos

    public ContaBancaria(string cpf, string titular)
    {
        Numero = contadorContas++;
        Cpf = cpf;
        Titular = titular;
        Saldo = 0;
    }

    public void Depositar(decimal valor)
    {
        if (valor <= 0)
        {
            Console.WriteLine("Valor de depósito inválido.");

            return;
        }

        Saldo += valor;
    }

    public bool Sacar(decimal valor)
    {
        if (valor <= 0)
        {
            Console.WriteLine("Valor de saque inválido.");

            return false;
        }

        if (valor > Saldo)
        {
            Console.WriteLine("Valor de saque inválido.");

            return false;
        }

        Saldo -= valor;

        return true;
    }
}

class App
{
    static void Main()
    {
        ContaBancaria contaJohn = new ContaBancaria("148.578.595-25", "John Doe");

        /* Linhas abaixo causariam erro se descomentadas, pois são read-only */
        // contaJohn.Numero = 25;
        // contaJohn.Titular = "Mary Monroe";

        /* Linha abaixo causaria erro se descomentada, pois tem setter privado */
        // contaJohn.Saldo = 1000000;

        Console.WriteLine($"Conta {contaJohn.Numero} em nome de {contaJohn.Titular}: Saldo de {contaJohn.Saldo}.");

        contaJohn.Depositar(100);

        Console.WriteLine($"Saque de R$ 30,00 {(contaJohn.Sacar(30) ? "bem sucedido!" : "Não foi concluído.")}"); // Bem sucedido
        
        Console.WriteLine($"Saque de R$ 100,00 {(contaJohn.Sacar(100) ? "bem sucedido!" : "Não foi concluído.")}"); // Não concluído

        Console.WriteLine($"Conta {contaJohn.Numero} em nome de {contaJohn.Titular}: Saldo de {contaJohn.Saldo}.");
    }
}
