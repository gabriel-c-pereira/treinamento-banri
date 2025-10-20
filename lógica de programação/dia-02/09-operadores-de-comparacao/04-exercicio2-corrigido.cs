// 2. Exploração de resultados booleanos

using System;

class App
{

    static void Main()
    {
        const string SENHA = "TRE1N4MENT0_MM";
        Console.Write("Digite a senha: ");
        string senhaUsuario = Console.ReadLine();

        Console.WriteLine($"Senha válida? {senhaUsuario == SENHA}");
    }
}
