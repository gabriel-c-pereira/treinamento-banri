// 1. Composição funcional

// Contém um nível de programação funcional suficiente para o objetivo didático, respeitando alguns princípios básicos. 
// Porém ainda não faz uso de recursos de programação funcional como por exemplo HOF (high order functions - lambdas).

using System;

class App
{
    const decimal ALIQUOTA_MUNICIPAL = 0.05m, ALIQUOTA_ESTADUAL = 0.08m, ALIQUOTA_FEDERAL = 0.10m;

    static void Main()
    {
        Console.Write("Digite o valor base do produto: ");
        decimal precoBase = Convert.ToDecimal(Console.ReadLine());

        // Funções (métodos) puras
        decimal valorImpostoMunicipal = CalcularImpostoMunicipal(precoBase);
        decimal valorImpostoEstadual = CalcularImpostoEstadual(precoBase);
        decimal valorImpostoFederal = CalcularImpostoFederal(precoBase);

        List<decimal> listaImpostos = new List<decimal> {
            valorImpostoMunicipal,
            valorImpostoEstadual,
            valorImpostoFederal 
        };

        // Função recursiva pura
        decimal valorTotalImpostos = SomarImpostos(listaImpostos, 0);

        // Última função pura
        decimal precoFinal = CalcularPrecoFinal(precoBase, valorTotalImpostos);

        Console.WriteLine($"\nImposto Municipal: R$ {valorImpostoMunicipal:F2}");
        Console.WriteLine($"Imposto Estadual:  R$ {valorImpostoEstadual:F2}");
        Console.WriteLine($"Imposto Federal:   R$ {valorImpostoFederal:F2}");
        
        Console.WriteLine($"Preço sem impostos: R$ {precoBase:F2}");
        Console.WriteLine($"Preço com impostos: R$ {precoFinal:F2}");
    }
    
    static decimal CalcularImpostoMunicipal(decimal valor)
    {
        return valor * ALIQUOTA_MUNICIPAL;
    }

    static decimal CalcularImpostoEstadual(decimal valor)
    {
        return valor * ALIQUOTA_ESTADUAL;
    }

    static decimal CalcularImpostoFederal(decimal valor)
    {
        return valor * ALIQUOTA_FEDERAL;
    }

    static decimal SomarImpostos(List<decimal> impostos, int nivel)
    {
        if (nivel >= impostos.Count)
            return 0;

        return impostos[nivel] + SomarImpostos(impostos, nivel + 1);
    }

    static decimal CalcularPrecoFinal(decimal precoBase, decimal valorTotalImpostos)
    {
        return precoBase + valorTotalImpostos;
    }
}
