using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adivinha
{
    class Program
    {
        static void Main()
        {
            int numero = new Random().Next(1, 11);
            int tentativas = 0;
            bool acertou = false;

            while(!acertou)
            {
                Console.WriteLine("Escolha um número de 1 até 10: ");
                int numeroEscolhido = Convert.ToInt32(Console.ReadLine());
                tentativas++;

                if (numeroEscolhido == numero)
                {
                    Console.WriteLine($"Parabéns! Você acertou o número e precisou de {tentativas} tentativas.");
                    acertou = true;
                }
                else
                {
                    Console.WriteLine("Você errou, tente novamente.");

                    if (numeroEscolhido > numero)
                    {
                        Console.WriteLine("O número secreto é menor!");
                    }
                    else
                    {
                        Console.WriteLine("O número secreto é maior!");
                    }
                }
            }            
        }
    }
}
