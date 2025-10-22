// 1. Sorveteria

using System;

class Sorveteria
{
    // Preço de cada sabor de sorvete
    const double PRECO_CHOCOLATE = 5, PRECO_MORANGO = 6, PRECO_FLOCOS = 4;

    static void Main()
    {
        // Quantidade de sorvetes pedidos pelo cliente
        int qtdChocolate = ObterQuantidadeSorvetes("chocolate");
        int qtdMorango = ObterQuantidadeSorvetes("morango");
        int qtdFlocos = ObterQuantidadeSorvetes("flocos");

        // Cálculo do total do pedido
        double totalChocolate = CalcularSubtotal(qtdChocolate, PRECO_CHOCOLATE);
        double totalMorango = CalcularSubtotal(qtdMorango, PRECO_MORANGO);
        double totalFlocos = CalcularSubtotal(qtdFlocos, PRECO_FLOCOS);

        double totalPedido = CalcularTotal(totalChocolate, totalMorango, totalFlocos);

        // Aplicação de desconto
        int qtdTotalSorvetes = qtdChocolate + qtdMorango + qtdFlocos;

        totalPedido = AplicarDesconto(totalPedido, qtdTotalSorvetes);

        // Verificação de promoção de cobertura gratuita
        bool coberturaGratuita = TemCoberturaGratuita(totalPedido);

        // Impressão do resumo
        ExibirResumo(totalPedido, coberturaGratuita);
    }

    // Método para obter as quantidades de sorvetes do usuário
    static int ObterQuantidadeSorvetes(string sabor)
    {
        Console.Write($"Quantos sorvetes de {sabor}? ");
        
        return int.Parse(Console.ReadLine());
    }

    // Método para calcular subtotais por sabor de sorvete
    static double CalcularSubtotal(int quantidade, double preco)
    {
        return quantidade * preco;
    }

    // Método para calcular o total de todos os sorvetes
    static double CalcularTotal(double subtotalChocolate, double subtotalMorango, double subtotalFlocos)
    {
        return subtotalChocolate + subtotalMorango + subtotalFlocos;
    }
    
    // Método para verificar regra e aplicar desconto
    static double AplicarDesconto(double total, int totalSorvetes)
    {
        if (totalSorvetes > 5) // Mais do que 5 sorvetes tem desconto de 10%
        {
            total -= total / 10;
        }

        return total;
    }

    // Método para verificar regra de promoção de cobertura gratuita
    static bool TemCoberturaGratuita(double total)
    {
        if (total > 20)
        {
            return true;
        }

        return false;

        // return total > 20; // Simplificação
    }

    // Método para exibir o resumo do pedido
    static void ExibirResumo(double total, bool coberturaGratuita)
    {
        if (coberturaGratuita)
        {
            Console.WriteLine($"Total do pedido: R$ {total:0.00} e com cobertura gratuita!");
        }
        else
        {
            Console.WriteLine($"Total do pedido: R$ {total:0.00}.");
        }
    }
}
