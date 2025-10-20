// 3. Relação booleano-numérica

using System;

class App
{
    static void Main()
    {
        // Solicita os números ao usuário
        Console.Write("Digite o primeiro número: ");
        int numero1 = Convert.ToInt32(Console.ReadLine()); // ou Convert.ToDouble(Console.ReadLine())

        Console.Write("Digite o segundo número: ");
        int numero2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"\n{numero1} > {numero2} → {numero1 > numero2}");
        Console.WriteLine($"{numero1} < {numero2} → {numero1 < numero2}");
        Console.WriteLine($"{numero1} == {numero2} → {numero1 == numero2}");
        Console.WriteLine($"{numero1} != {numero2} → {numero1 != numero2}");
        Console.WriteLine($"{numero1} >= {numero2} → {numero1 >= numero2}");
        Console.WriteLine($"{numero1} <= {numero2} → {numero1 <= numero2}");
    }
}
