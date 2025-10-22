// 2. Desconto por categoria

using System;

class App
{
    static void Main()
    {
        Console.Write("Digite o preço do produto: ");
        double preco = double.Parse(Console.ReadLine());

        Console.Write("Digite a categoria do cliente (Bronze, Prata, Ouro ou VIP): ");
        string categoria = Console.ReadLine().Trim();

        double desconto =
            categoria.Equals("VIP", StringComparison.OrdinalIgnoreCase) ? 35 : // Extra: StringComparison.OrdinalIgnoreCase para ignorar o casing
            categoria.Equals("Ouro", StringComparison.OrdinalIgnoreCase) ? 25 :
            categoria.Equals("Prata", StringComparison.OrdinalIgnoreCase) ? 10 :
            categoria.Equals("Bronze", StringComparison.OrdinalIgnoreCase) ? 5 : 
            0;

        double percentualRestantePreco = 1 - (desconto / 100);

        double precoFinal = preco * percentualRestantePreco;

        Console.WriteLine($"\nPreço final com desconto: R$ {precoFinal:F2}");
        Console.WriteLine($"Desconto aplicado: {desconto:F0}%");
        Console.WriteLine($"Categoria do cliente: {categoria}");
    }
}
