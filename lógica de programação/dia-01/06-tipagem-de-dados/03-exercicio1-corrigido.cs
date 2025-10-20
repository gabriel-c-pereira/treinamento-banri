// 1. Exploração de tipos

using System;

class App
{
    static void Main()
    {
        // char emojiModerno = '😊'; // Erro - Código não compila: fora do BMP, não cabe em 1 char (necessita ao menos 2 chars equivalente a um int de 32 bits de memória - UTF-32)
        char emojiPrimitivo = '☺';
        Console.WriteLine($"Emoji: {emojiPrimitivo}");

        char letra = 'A';
        int codigoUnicode = letra;  // Conversão implícita - 65 é o código ASCII/Unicode da letra 'A'
        Console.WriteLine($"Código Unicode da letra '{letra}': {codigoUnicode}");

        string usuarioLogado = "TRUE";
        bool isUsuarioLogado = Convert.ToBoolean(usuarioLogado); // Conversão explícita com método
        Console.WriteLine($"Usuário logado? {isUsuarioLogado}");

        double gamePoints = 84.68;
        int balasChocolate = (int)gamePoints; // Conversão explícita com casting - truncamento da parte decimal
        Console.WriteLine($"Pontos ganhos: {gamePoints} | Balas de chocolate: {balasChocolate}");
    }
}
