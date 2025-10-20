// 2. Número positivo e par

using System;

class App
{
    static void Main()
    {
        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());
        bool positivo = numero > 0;
        bool par = numero % 2 == 0;

        bool positivoEPar = positivo && par;

        Console.WriteLine($"O número é positivo e par? {positivoEPar}");
    }
}
