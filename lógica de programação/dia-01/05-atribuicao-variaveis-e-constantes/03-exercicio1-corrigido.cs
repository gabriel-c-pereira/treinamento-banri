// 1. Ingressos de show

using System;

class App
{
    static void Main()
    {
        // Constante
        const int CAPACIDADE_MAXIMA = 1000;

        // Variáveis
        int ingressosVendidos = 75;
        int ingressosRestantes = CAPACIDADE_MAXIMA - ingressosVendidos;

        Console.WriteLine($"Ingressos vendidos: {ingressosVendidos} de {CAPACIDADE_MAXIMA}");
        Console.WriteLine($"Ingressos restantes: {ingressosRestantes}");
    }
}
