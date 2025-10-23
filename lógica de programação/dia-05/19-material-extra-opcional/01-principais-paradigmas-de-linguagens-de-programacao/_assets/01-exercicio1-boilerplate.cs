using System;

class App
{
    const decimal ALIQUOTA_MUNICIPAL = 0.05m, ALIQUOTA_ESTADUAL = 0.08m, ALIQUOTA_FEDERAL = 0.10m;

    static void Main()
    {
        Console.Write("Digite o valor base do produto: ");
        decimal precoBase = Convert.ToDecimal(Console.ReadLine());

        decimal valorImpostoMunicipal = precoBase * ALIQUOTA_MUNICIPAL;
        decimal valorImpostoEstadual = precoBase * ALIQUOTA_ESTADUAL;
        decimal valorImpostoFederal = precoBase * ALIQUOTA_FEDERAL;

        decimal precoFinal = precoBase + valorImpostoMunicipal + valorImpostoEstadual + valorImpostoFederal;

        Console.WriteLine($"\nImposto Municipal: R$ {valorImpostoMunicipal:F2}");
        Console.WriteLine($"Imposto Estadual:  R$ {valorImpostoEstadual:F2}");
        Console.WriteLine($"Imposto Federal:   R$ {valorImpostoFederal:F2}");
        
        Console.WriteLine($"Preço sem impostos: R$ {precoBase:F2}");
        Console.WriteLine($"Preço com impostos: R$ {precoFinal:F2}");
    }
}
