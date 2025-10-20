// 3. Ano bissexto

using System;

class App
{
    static void Main()
    {
        Console.Write("Digite um ano: ");
        int ano = int.Parse(Console.ReadLine());

        bool divisivelPor4 = ano % 4 == 0;
        bool divisivelPor100 = ano % 100 == 0;
        bool divisivelPor400 = ano % 400 == 0;

        bool ehBissexto = (divisivelPor4 && !divisivelPor100) || divisivelPor400;

        Console.WriteLine($"O ano {ano} é bissexto? {ehBissexto}");
    }
}
