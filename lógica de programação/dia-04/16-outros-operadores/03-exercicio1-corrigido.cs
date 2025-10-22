// 1. Controle de permissões

using System;

class App
{
    static void Main()
    {
        int permissoes = 0; // 0b000 → nenhuma permissão ativa

        Console.WriteLine("Controle de Permissões");
        Console.WriteLine("Permissões: Ler = bit 0, Escrever = bit 1, Excluir = bit 2");

        Console.Write("Digite a permissão (Ler, Escrever, Excluir): ");
        string permissao = Console.ReadLine().ToLower();

        Console.Write("Digite a operação (Ativar, Desativar, Verificar): ");
        string operacao = Console.ReadLine().ToLower();

        int bit =
            permissao == "ler" ? 0 : // 0b001
            permissao == "escrever" ? 1 : // 0b010
            permissao == "excluir" ? 2 : // 0b100
            -1;

        /*
         * Inicia a máscara já como "ler" (0b001), então se o bit "ler" (0), vai fazer deslocamento de zero, 
         * mantendo em 0b001. Se o bit for "escrever" (1), desloca uma vez para a esquerda, ficando 0b010. 
         * Se o bit for "excluir" (2), desloca duas vezes para a esquerda, ficando 0b100.
         * - A máscara é o valor que indica qual permissão será manipulada, e será muito importante na aplicação das operações.
        */
        int mascara = 0b001 << bit;

        switch (operacao)
        {
            case "ativar":
                /* 
                 * Exemplo: 
                 *  permissoes = 0b000
                 *  mascara = 0b010 // "escrever"
                 *  
                 *  0b000 | 0b010 = 0b010 (permissão "escrever" ativada)
                */
                permissoes = permissoes | mascara;

                Console.WriteLine("Permissão ativada!");

                break;
            case "desativar":
                /* 
                 * Exemplo: 
                 *  permissoes = 0b010
                 *  mascara = 0b010 // "escrever"
                 *  
                 *  0b010 & ~0b010 = 0b000 (permissão "escrever" desativada)
                */
                permissoes = permissoes & ~mascara;

                Console.WriteLine("Permissão desativada!");

                break;
            case "verificar":
                /* 
                 * Exemplo: 
                 *  permissoes = 0b100
                 *  mascara = 0b100 // "excluir"
                 *  
                 *  0b100 & 0b100 != 0b000 (nesse caso sim, logo, permissão "excluir" está ativa)
                */
                bool ativa = (permissoes & mascara) != 0;

                Console.WriteLine($"Permissão {(ativa ? "ativa" : "inativa")}.");

                break;
        }

        Console.WriteLine($"Valor inteiro: {permissoes}");
        Console.WriteLine($"Representação binária: {Convert.ToString(permissoes, 2).PadLeft(3, '0')}");
    }
}
