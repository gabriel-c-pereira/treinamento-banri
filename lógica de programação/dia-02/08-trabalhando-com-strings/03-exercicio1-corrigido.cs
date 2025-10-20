// 1. Exploração de strings

using System;

class App
{
    static void Main()
    {
        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();

        Console.Write("Digite seu sobrenome: ");
        string sobrenome = Console.ReadLine();

        Console.WriteLine($"{nome} {sobrenome}");

        string inicialNome = nome.Substring(0, 1).ToUpper();
        string inicialSobrenome = sobrenome.Substring(0, 1).ToUpper();
        int totalCaracteres = nome.Length + sobrenome.Length;
        Console.WriteLine($"Iniciais e contagem: {inicialNome}.{inicialSobrenome}. ({totalCaracteres})");

        int posicaoMeioNome = nome.Length / 2;
        string primeiraMetadeNome = nome.Substring(0, posicaoMeioNome);
        int posicaoMeioSobrenome = sobrenome.Length / 2;
        string segundaMetadeSobrenome = sobrenome.Substring(posicaoMeioSobrenome);
        string nomeSecreto = $"{primeiraMetadeNome}{segundaMetadeSobrenome}"; // ou string.Concat(primeiraMetadeNome, segundaMetadeSobrenome);
        Console.WriteLine($"Nome secreto: {nomeSecreto}");
    }
}
