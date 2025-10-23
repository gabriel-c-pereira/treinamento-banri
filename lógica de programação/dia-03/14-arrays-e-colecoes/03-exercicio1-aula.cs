// 1. Jogo da velha

using System;

class TicTacToe
{
    static void ExibirTabuleiro(string[,] tabuleiro)
    {
        Console.WriteLine($" {tabuleiro[0, 0]} | {tabuleiro[0, 1]} | {tabuleiro[0, 2]}");
        Console.WriteLine("---+---+---");
        Console.WriteLine($" {tabuleiro[1, 0]} | {tabuleiro[1, 1]} | {tabuleiro[1, 2]}");
        Console.WriteLine("---+---+---");
        Console.WriteLine($" {tabuleiro[2, 0]} | {tabuleiro[2, 1]} | {tabuleiro[2, 2]}");
    }
    static void Main()
    {
        string[,] tabuleiro = new string[3, 3] { { " ", " ", " " }, { " ", " ", " " }, { " ", " ", " " } };
        Console.WriteLine("Bem vindo ao jogo da velha!");

        for (int turnos = 1; turnos <= 9; turnos += 2)
        {
            ExibirTabuleiro(tabuleiro);

            // Pedir jogada jogador X
            Console.WriteLine("É a vez do jogador X. Selecione uma posição para jogar");
            Console.WriteLine("Digite a posição da linha desejada (de 0 até 2): ");
            int linhaJogadorX = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a posição da coluna desejada (de 0 até 2): ");
            int colunaJogadorX = Convert.ToInt32(Console.ReadLine());

            if (linhaJogadorX == 9 || colunaJogadorX == 9)
            {
                break;
            }

            tabuleiro[linhaJogadorX, colunaJogadorX] = "X";

            ExibirTabuleiro(tabuleiro);


            // Pedir jogada jogador O
            Console.WriteLine("É a vez do jogador O. Selecione uma posição para jogar");
            Console.WriteLine("Digite a posição da linha desejada: ");
            int linhaJogadorO = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a posição da coluna desejada: ");
            int colunaJogadorO = Convert.ToInt32(Console.ReadLine());

            if (linhaJogadorO == 9 || colunaJogadorO == 9)
            {
                break;
            }


            tabuleiro[linhaJogadorO, colunaJogadorO] = "O";

            ExibirTabuleiro(tabuleiro);
        }

        
    }
}
