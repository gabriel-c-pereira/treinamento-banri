using System;
using System.Collections.Generic;

class Biblioteca
{
    static Dictionary<int, string> obras;
    static Dictionary<int, string> leitores;
    static int TotalObrasEmEmprestimo;
    static Dictionary<int, int> quantidades;
    static Dictionary<int, string> autores;

    static void Main()
    {
        Console.WriteLine("Iniciando a biblioteca...");

        obras = new Dictionary<int, string>();
        autores = new Dictionary<int, string>();
        quantidades = new Dictionary<int, int>();

        leitores = new Dictionary<int, string>();
        int idLeitor = 1;

        TotalObrasEmEmprestimo = 0;

        CadastrarObras();

        while (true)
        {
            Console.WriteLine($"\nDigite o nome do leitor {idLeitor} (ou 'S' para sair do cadastro de leitores):");
            string inputNome = Console.ReadLine();

            if (inputNome.ToUpper() == "S")
                break;

            leitores.Add(idLeitor, inputNome);

            idLeitor++;
        }

        if (obras.Count == 0 || leitores.Count == 0)
        {
            Console.WriteLine("\nEncerrando a biblioteca por falta de obras ou leitores cadastrados...");

            return;
        }

        while (true)
        {
            ImprimirMenu();
            string opcao = Console.ReadLine().ToUpper();

            if (opcao == "S")
                break;

            switch (opcao)
            {
                case "1":
                    {
                        EmprestarObra();
                        break;
                    }
                case "2":
                    {
                        DevolverObra();
                        break;
                    }
                case "3":
                    {
                        ListarObras();
                        break;
                    }
                case "4":
                    {
                        ListarLeitores();
                        break;
                    }
                case "5":
                    {
                        MostrarEstatisticas();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("\nOpção inválida.");
                        break;
                    }
            }
        }

        Console.WriteLine("\nEncerrando a biblioteca...");
    }
    static void EmprestarObra()
    {
        Console.Write("\nDigite o ID da obra a emprestar: ");
        string inputIdObra = Console.ReadLine();

        if (!int.TryParse(inputIdObra, out idObra))
        {
            Console.WriteLine("Obra inválida.");

            break;
        }

        if (!obras.ContainsKey(idObra))
        {
            Console.WriteLine("Obra não encontrada.");

            break;
        }

        if (quantidades[idObra] <= 0)
        {
            Console.WriteLine("Obra indisponível no momento.");

            break;
        }

        Console.Write("Digite o ID do leitor: ");
        string inputIdLeitor = Console.ReadLine();

        if (!int.TryParse(inputIdLeitor, out idLeitor))
        {
            Console.WriteLine("Leitor inválido.");

            break;
        }

        if (!leitores.ContainsKey(idLeitor))
        {
            Console.WriteLine("Leitor não encontrado.");

            break;
        }

        quantidades[idObra]--;

        Console.WriteLine($"{leitores[idLeitor]} pegou emprestada a obra '{obras[idObra]}'.");

        TotalObrasEmEmprestimo++;
    }

    static void DevolverObra()
    {
        Console.Write("\nDigite o ID da obra a devolver: ");
        string inputIdObra = Console.ReadLine();

        if (!int.TryParse(inputIdObra, out idObra))
        {
            Console.WriteLine("Obra inválida.");

            break;
        }

        if (!obras.ContainsKey(idObra))
        {
            Console.WriteLine("Obra não encontrada.");

            break;
        }

        quantidades[idObra]++;

        Console.WriteLine($"Obra '{obras[idObra]}' devolvida.");

        TotalObrasEmEmprestimo--;
    }

    static void ListarObras()
    {
        Console.WriteLine("\nLista de obras:");
        var idsObras = new List<int>(obras.Keys);
        for (int i = 0; i < idsObras.Count; i++)
        {
            int id = idsObras[i];

            Console.WriteLine($"Obra: ({id}) {obras[id]} - Autor: {autores[id]} - Quantidade: {quantidades[id]} unidade(s)");
        }
    }

    static void ListarLeitores()
    {
        Console.WriteLine("\nLista de leitores:");

        var idsLeitores = new List<int>(leitores.Keys);
        for (int i = 0; i < idsLeitores.Count; i++)
        {
            int id = idsLeitores[i];

            Console.WriteLine($"Leitor: ({id}) {leitores[id]}");
        }
    }

    static void MostrarEstatisticas()
    {
        Console.WriteLine("\nEstatísticas:");

        int totalObrasDisponiveis = 0;

        var idsObras = new List<int>(obras.Keys);
        for (int i = 0; i < idsObras.Count; i++)
        {
            int id = idsObras[i];

            totalObrasDisponiveis += quantidades[id];
        }

        Console.WriteLine($"Total de obras disponíveis: {totalObrasDisponiveis}");
        Console.WriteLine($"Total de obras em empréstimo: {TotalObrasEmEmprestimo}");
    }

    static void ImprimirMenu()
    {
        Console.WriteLine("\n1 - Emprestar obra");
        Console.WriteLine("2 - Devolver obra");
        Console.WriteLine("3 - Listar obras");
        Console.WriteLine("4 - Listar leitores");
        Console.WriteLine("5 - Estatísticas");
        Console.WriteLine("S - Sair");
        Console.Write("Selecione a ação: ");
    }
    
    static void CadastrarObras()
    {
        int idObra = 1;
        while (true)
        {
            Console.WriteLine($"\nDigite o título da obra {idObra} (ou 'S' para sair do cadastro de obras):");
            string inputTitulo = Console.ReadLine();

            if (inputTitulo.ToUpper() == "S")
                break;

            obras.Add(idObra, inputTitulo);

            Console.WriteLine($"Digite o nome do autor da obra '{inputTitulo}':");

            autores.Add(idObra, Console.ReadLine());

            Console.WriteLine($"Digite a quantidade inicial disponível da obra '{inputTitulo}':");
            string inputQuantidade = Console.ReadLine();

            if (!int.TryParse(inputQuantidade, out int quantidade))
                quantidade = 0; // valor padrão caso não seja informada uma quantidade válida

            quantidades.Add(idObra, quantidade);

            idObra++;
        }
    }
}
