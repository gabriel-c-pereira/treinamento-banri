// 1. Brinquedo no parque

using System;

class App
{
    static void Main()
    {
        Console.Write("Digite a altura da criança (em centímetros): ");
        double altura = double.Parse(Console.ReadLine());

        Console.Write("A criança está acompanhada de um adulto? (true/false): ");
        bool acompanhada = bool.Parse(Console.ReadLine());

        bool podeEntrar = altura >= 120 || acompanhada;

        Console.WriteLine($"Pode entrar no brinquedo? {podeEntrar}");
    }
}
