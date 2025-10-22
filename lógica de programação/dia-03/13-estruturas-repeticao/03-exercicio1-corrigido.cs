// 1. Adivinhe o número

using System;

class App
{
    static void Main()
    {
        Console.WriteLine("Estou pensando em um número entre 1 e 10...\n");

        int numeroSecreto = new Random().Next(1, 11);

        int tentativas = 0;
        int palpite = 0;

        while (palpite != numeroSecreto)
        {
            Console.Write("Qual é o seu palpite? ");
            string entrada = Console.ReadLine();

            // Dica extra: validação mais segura e elegante de input do usuário
            if (!int.TryParse(entrada, out palpite))
            {
                Console.WriteLine("Por favor, digite um número válido.");

                continue;
            }

            if (palpite < numeroSecreto)
                Console.WriteLine("O número secreto é maior!");
            else if (palpite > numeroSecreto)
                Console.WriteLine("O número secreto é menor!");

            tentativas++;
        }

        Console.WriteLine($"Acertou! Você precisou de {tentativas} tentativas.");
    }
}
