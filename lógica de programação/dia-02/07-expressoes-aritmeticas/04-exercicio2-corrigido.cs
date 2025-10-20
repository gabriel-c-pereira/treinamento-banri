// 2. Exploração do operador módulo (%) - Desafiador/Opcional

using System;

class App
{
    static void Main()
    {
        Console.Write("Digite um número inteiro de três dígitos: ");
        int numero = int.Parse(Console.ReadLine()); // ou Convert.ToInt32(Console.ReadLine());

        int soma = 0;

        // Unidade
        int unidade = numero % 10;
        Console.WriteLine($"Unidade: {unidade}");
        soma += unidade;

        // Dezena
        int dezena = (numero / 10) % 10;
        Console.WriteLine($"Dezena: {dezena}");
        soma += dezena;

        // Centena
        int centena = (numero / 100) % 10;
        Console.WriteLine($"Centena: {centena}");
        soma += centena;

        Console.WriteLine($"Soma dos dígitos: {soma}");
    }
}
