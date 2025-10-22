// 2. Menu interativo de assistente virtual

using System;

class AssistenteVirtual
{
    static void Main()
    {
        int opcaoSelecionada = -1;

        /* Executar infinitamente o assistente virtual, executando cada ação conforme
         * selecionado pelo usuário, até que o mesmo selecione a opção para encerrar
        */
        do
        {
            ExibirMenu();

            string entrada = Console.ReadLine();

            if (!int.TryParse(entrada, out opcaoSelecionada))
            {
                Console.WriteLine("Por favor, digite uma opção válida.\n");

                continue;
            }

            // Executar ação conforme a opção selecionada
            switch (opcaoSelecionada)
            {
                case 1:
                    Console.WriteLine($"Data atual: {ObterDataAtual()}\n");
                    break;
                case 2:
                    Console.WriteLine($"Hora atual: {ObterHoraAtual()}\n");
                    break;
                case 3:
                    DizerOla();
                    break;
                case 0:
                    Console.WriteLine("Encerrando o assistente virtual. Até mais...");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.\n");
                    break;
            }
        } while (opcaoSelecionada != 0);
    }

    // Método para exibir as opções de menu para o usuário
    static void ExibirMenu()
    {
        Console.WriteLine("===== Menu Interativo =====");
        Console.WriteLine("1 - Exibir data atual");
        Console.WriteLine("2 - Exibir hora atual");
        Console.WriteLine("3 - Exibir saudação");
        Console.WriteLine("0 - Finalizar");
        Console.WriteLine("===========================");
        Console.Write("Escolha uma opção válida: ");
    }

    // Método que retorna a data atual formatada
    static string ObterDataAtual()
    {
        return DateTime.Now.ToString("dd/MM/yyyy");
    }

    // Método que retorna a hora atual formatada
    static string ObterHoraAtual()
    {
        return DateTime.Now.ToString("HH:mm");
    }

    // Método que imprime uma saudação
    static void DizerOla()
    {
        Console.WriteLine("Olá, usuário!\n");
    }
}
