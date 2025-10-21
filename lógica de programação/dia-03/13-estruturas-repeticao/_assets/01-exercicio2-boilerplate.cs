using System;

class AssistenteVirtual
{
    static void Main()
    {
        int opcaoSelecionada = -1;

        /* Executar infinitamente o assistente virtual, executando cada ação conforme
         * selecionado pelo usuário, até que o mesmo selecione a opção para encerrar
        */
        // TODO
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
