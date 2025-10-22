// 1. Biblioteca

using System;
using System.Collections.Generic;

class App
{
    static void Main()
    {
        Console.WriteLine("Iniciando a biblioteca...");

        // Cadastro inicial de obras
        bool cadastrarProximaObra = true;
        while (cadastrarProximaObra)
            cadastrarProximaObra = Biblioteca.CadastrarNovaObra();

        // Cadastro inicial de leitores
        bool cadastrarProximoLeitor = true;
        while (cadastrarProximoLeitor)
            cadastrarProximoLeitor = Biblioteca.CadastrarNovoLeitor();

        // Validação para garantir que há obras e leitores cadastrados para as operações poderem ser realizadas
        if (Obra.ObterQuantidadeObrasUnicasCadastradas() == 0 || Leitor.ObterQuantidadeLeitoresCadastrados() == 0)
        {
            Console.WriteLine("\nEncerrando a biblioteca por falta de obras ou leitores cadastrados...");

            return;
        }

        // Menu de operações
        while (true)
        {
            Console.WriteLine("\n1 - Emprestar obra");
            Console.WriteLine("2 - Devolver obra");
            Console.WriteLine("3 - Listar obras");
            Console.WriteLine("4 - Listar leitores");
            Console.WriteLine("5 - Estatísticas");
            Console.WriteLine("S - Sair");
            Console.Write("Selecione a ação: ");
            string opcao = Console.ReadLine().ToUpper();

            if (opcao == "S")
                break;

            switch (opcao)
            {
                case "1":
                    Biblioteca.EmprestarObra();

                    break;
                case "2":
                    Biblioteca.DevolverObra();

                    break;
                case "3":
                    Biblioteca.ListarObras();

                    break;
                case "4":
                    Biblioteca.ListarLeitores();

                    break;
                case "5":
                    Biblioteca.ApresentarEstatisticas();

                    break;
                default:
                    Console.WriteLine("\nOpção inválida.");

                    break;
            }
        }

        Console.WriteLine("\nEncerrando a biblioteca...");
    }
}

class Obra
{
    static Dictionary<int, string> Titulos = new Dictionary<int, string>();
    static Dictionary<int, string> Autores = new Dictionary<int, string>();
    static Dictionary<int, int> Quantidades = new Dictionary<int, int>();

    public static void Cadastrar(int id, string titulo, string nomeAutor, int quantidade)
    {
        Titulos.Add(id, titulo);

        Autores.Add(id, nomeAutor);

        Quantidades.Add(id, quantidade);
    }

    public static int ObterQuantidadeObrasUnicasCadastradas()
    {
        return Titulos.Count;
    }

    public static bool Cadastrada(int id)
    {
        return Titulos.ContainsKey(id);
    }

    public static bool Disponivel(int id)
    {
        return Cadastrada(id) && Quantidades[id] > 0;
    }

    public static void Emprestar(int id)
    {
        Quantidades[id]--;
    }

    public static string ObterTitulo(int id)
    {
        return Titulos[id];
    }

    public static void Devolver(int id)
    {
        Quantidades[id]++;
    }

    public static List<int> ObterIdsObrasCadastradas()
    {
        return new List<int>(Titulos.Keys);
    }

    public static string ObterNomeAutor(int id)
    {
        return Autores[id];
    }

    public static int ObterQuantidade(int id)
    {
        return Quantidades[id];
    }

    public static int ObterQuantidadeObrasDisponiveis()
    {
        int totalObrasDisponiveis = 0;

        var ids = ObterIdsObrasCadastradas();
        for (int i = 0; i < ids.Count; i++)
        {
            int id = ids[i];

            totalObrasDisponiveis += Quantidades[id];
        }

        return totalObrasDisponiveis;
    }
}

class Leitor
{
    static Dictionary<int, string> Nomes = new Dictionary<int, string>();

    public static void Cadastrar(int id, string nome)
    {
        Nomes.Add(id, nome);
    }

    public static int ObterQuantidadeLeitoresCadastrados()
    {
        return Nomes.Count;
    }

    public static bool Cadastrado(int id)
    {
        return Nomes.ContainsKey(id);
    }

    public static string ObterNome(int id)
    {
        return Nomes[id];
    }

    public static List<int> ObterIdsLeitoresCadastrados()
    {
        return new List<int>(Nomes.Keys);
    }
}

class Biblioteca
{
    static int IdObra = 1;
    static int IdLeitor = 1;

    static int TotalObrasEmEmprestimo = 0;

    public static bool CadastrarNovaObra()
    {
        Console.WriteLine($"\nDigite o título da obra {IdObra} (ou 'S' para sair do cadastro de obras):");
        string inputTitulo = Console.ReadLine();

        if (inputTitulo.ToUpper() == "S")
            return false;

        Console.WriteLine($"Digite o nome do autor da obra '{inputTitulo}':");
        string inputAutor = Console.ReadLine();

        Console.WriteLine($"Digite a quantidade inicial disponível da obra '{inputTitulo}':");
        string inputQuantidade = Console.ReadLine();

        if (!int.TryParse(inputQuantidade, out int quantidade))
            quantidade = 0; // valor padrão caso não seja informada uma quantidade válida

        Obra.Cadastrar(IdObra, inputTitulo, inputAutor, quantidade);

        IdObra++;

        return true;
    }

    public static bool CadastrarNovoLeitor()
    {
        Console.WriteLine($"\nDigite o nome do leitor {IdLeitor} (ou 'S' para sair do cadastro de leitores):");
        string inputNome = Console.ReadLine();

        if (inputNome.ToUpper() == "S")
            return false;

        Leitor.Cadastrar(IdLeitor, inputNome);

        IdLeitor++;

        return true;
    }

    public static void EmprestarObra()
    {
        Console.Write("\nDigite o ID da obra a emprestar: ");
        string inputIdObra = Console.ReadLine();

        if (!int.TryParse(inputIdObra, out int idObra))
        {
            Console.WriteLine("Obra inválida.");

            return;
        }

        if (!Obra.Disponivel(idObra))
        {
            Console.WriteLine("Obra indisponível no momento.");

            return;
        }

        Console.Write("Digite o ID do leitor: ");
        string inputIdLeitor = Console.ReadLine();

        if (!int.TryParse(inputIdLeitor, out int idLeitor))
        {
            Console.WriteLine("Leitor inválido.");

            return;
        }

        if (!Leitor.Cadastrado(idLeitor))
        {
            Console.WriteLine("Leitor não encontrado.");

            return;
        }

        Obra.Emprestar(idObra);

        Console.WriteLine($"{Leitor.ObterNome(idLeitor)} pegou emprestada a obra '{Obra.ObterTitulo(idObra)}'.");

        TotalObrasEmEmprestimo++;
    }

    public static void DevolverObra()
    {
        Console.Write("\nDigite o ID da obra a devolver: ");
        string inputIdObra = Console.ReadLine();

        if (!int.TryParse(inputIdObra, out int idObra))
        {
            Console.WriteLine("Obra inválida.");

            return;
        }

        if (!Obra.Cadastrada(idObra))
        {
            Console.WriteLine("Obra não encontrada.");

            return;
        }

        Obra.Devolver(idObra);

        Console.WriteLine($"Obra '{Obra.ObterTitulo(idObra)}' devolvida.");

        TotalObrasEmEmprestimo--;
    }

    public static void ListarObras()
    {
        Console.WriteLine("\nLista de obras:");

        var ids = Obra.ObterIdsObrasCadastradas();
        for (int i = 0; i < ids.Count; i++)
        {
            int id = ids[i];

            Console.WriteLine($"Obra: ({id}) {Obra.ObterTitulo(id)} - Autor: {Obra.ObterNomeAutor(id)} - Quantidade: {Obra.ObterQuantidade(id)} unidade(s)");
        }
    }

    public static void ListarLeitores()
    {
        Console.WriteLine("\nLista de leitores:");

        var ids = Leitor.ObterIdsLeitoresCadastrados();
        for (int i = 0; i < ids.Count; i++)
        {
            int id = ids[i];

            Console.WriteLine($"Leitor: ({id}) {Leitor.ObterNome(id)}");
        }
    }

    public static void ApresentarEstatisticas()
    {
        Console.WriteLine("\nEstatísticas:");

        Console.WriteLine($"Total de obras disponíveis: {Obra.ObterQuantidadeObrasDisponiveis()}");
        Console.WriteLine($"Total de obras em empréstimo: {TotalObrasEmEmprestimo}");
    }
}
