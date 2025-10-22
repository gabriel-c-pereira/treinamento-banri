// 3. Pirâmide do Mario

using System;

class App
{
    static void Main()
    {
        Console.Write("Digite a altura da pirâmide (1 a 8): ");
        int alturaPiramide = int.Parse(Console.ReadLine());

        // Validação
        if (alturaPiramide < 1 || alturaPiramide > 8)
        {
            Console.WriteLine("Altura inválida. Deve ser entre 1 e 8.");

            return;
        }

        // Construção da pirâmide linha a linha
        for (int i = 0; i < alturaPiramide; i++)
        {
            int linhaAtual = i + 1;

            // Imprimir espaços em branco da linha
            int numeroEspacos = alturaPiramide - linhaAtual;
            for (int j = numeroEspacos; j > 0; j--)
            {
                Console.Write(" ");
            }

            // Imprimir blocos # da linha
            int numeroBlocos = linhaAtual;
            for (int j = 0; j < numeroBlocos; j++)
            {
                Console.Write("#");
            }

            Console.WriteLine();
        }
    }
}
