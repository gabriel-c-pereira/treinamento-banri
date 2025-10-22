// 1. Jogo da velha

using System;

class TicTacToe
{
    static void Main()
    {
        char[,] tabuleiro = new char[3, 3] { { ' ', ' ', ' ' }, { ' ', ' ', ' ' }, { ' ', ' ', ' ' } };
        char jogador = 'X';
        int jogadas = 0;

        while (true)
        {
            ImprimirTabuleiro(tabuleiro);

            Console.Write($"Jogador {jogador} — escolha a linha (0 a 2): ");
            int linha = int.Parse(Console.ReadLine());

            Console.Write($"Jogador {jogador} — escolha a coluna (0 a 2): ");
            int coluna = int.Parse(Console.ReadLine());

            if (linha == 9 || coluna == 9)
            {
                Console.WriteLine($"\nJogo encerrado pelo jogador {jogador}.");

                break;
            }

            jogadas++;

            if (jogadas == 9)
            {
                Console.WriteLine($"\nJogo encerrado com um empate!");

                break;
            }

            if (JogadorVenceu(jogador, tabuleiro))
            {
                ImprimirTabuleiro(tabuleiro);

                Console.WriteLine($"\nJogo encerrado. Jogador {jogador} venceu!");
                
                break;
            }

            if (jogador == 'X')
                jogador = 'O';
            else
                jogador = 'X';
        }
    }

    static void ImprimirTabuleiro(char[,] tabuleiro)
    {
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($" {tabuleiro[i, 0]} | {tabuleiro[i, 1]} | {tabuleiro[i, 2]} ");

            if (i < 2)
                Console.WriteLine("---+---+---");
        }
    }

    static bool JogadorVenceu(char jogador, char[,] tabuleiro)
    {
        // Verificação horizontal
        for (int i = 0; i < 3; i++)
        {
            if (tabuleiro[i, 0] == jogador && tabuleiro[i, 1] == jogador && tabuleiro[i, 2] == jogador)
                return true;
        }

        // Verificação vertical
        for (int i = 0; i < 3; i++)
        {
            if (tabuleiro[0, i] == jogador && tabuleiro[1, i] == jogador && tabuleiro[2, i] == jogador)
                return true;
        }

        // Verificação diagonal principal
        if (tabuleiro[0, 0] == jogador && tabuleiro[1, 1] == jogador && tabuleiro[2, 2] == jogador)
            return true;

        // Verificação diagonal secundária
        if (tabuleiro[0, 2] == jogador && tabuleiro[1, 1] == jogador && tabuleiro[2, 0] == jogador)
            return true;

        // Se nenhuma verificação é verdadeira, ainda não venceu
        return false;
    }
}
