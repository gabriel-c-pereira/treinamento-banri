// 1. Exploração de operações matemáticas

using System;

class App
{
    static void Main()
    {
        // Solicita os números ao usuário
        Console.Write("Digite o primeiro número: ");
        string numeroDado1 = Console.ReadLine();
        double numero1 = double.Parse(numeroDado1); // ou Convert.ToDouble(numeroDado1)

        Console.Write("Digite o segundo número: ");
        string numeroDado2 = Console.ReadLine();
        double numero2 = double.Parse(numeroDado2);

        // Soma
        double soma = numero1 + numero2;
        Console.WriteLine($"\nSoma: {soma}");

        // Subtração
        double subtracao = numero1 - numero2;
        Console.WriteLine($"Subtração: {subtracao}");

        // Multiplicação
        double multiplicacao = numero1 * numero2;
        Console.WriteLine($"Multiplicação: {multiplicacao}");

        // Divisão
        // double divisao = numero1 / numero2; Se numero2 for 0, gera erro de runtime
        if (numero2 != 0)
        {
            double divisao = numero1 / numero2;
            Console.WriteLine($"Divisão: {divisao}");
        }
        else
        {
            Console.WriteLine("Divisão: impossível dividir por zero!");
        }

        // Resto
        // double resto = numero1 % numero2; Se numero2 for 0, gera erro de runtime
        if (numero2 != 0)
        {
            double resto = numero1 % numero2;
            Console.WriteLine($"Resto: {resto}");
        }
        else
        {
            Console.WriteLine("Resto: impossível calcular o módulo com divisor zero!");
        }
    }
}
