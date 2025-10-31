// 2. Cadastros de funcionários

using System;

public class Cidade
{
    public string Nome { get; }
    public string Estado { get; }
    public string Pais { get; }

    public Cidade(string nome, string estado, string pais)
    {
        Nome = nome;
        Estado = estado;
        Pais = pais;
    }
}

public class Endereco
{
    public string Rua { get; }
    public int Numero { get; }
    public string Bairro { get; }

    public string Cidade => _cidade.Nome; // É o mesmo que public string Cidade { get { return _cidade.Nome; } }
    public string Estado => _cidade.Estado;
    public string Pais => _cidade.Pais;
    
    private Cidade _cidade { get; }

    /* 
    * Esses construtores vão começar a parecer grandes demais... 
    * Para isso, existem outras técnicas, como uso de método de adição (ex.: AddCidade) ou 
    * o uso de factories.
    */
    public Endereco(
        string rua,
        int numero,
        string bairro,
        string cidade,
        string estado,
        string pais
    )
    {
        Rua = rua;
        Numero = numero;
        Bairro = bairro;

        _cidade = new Cidade(cidade, estado, pais);
    }
}

public class Cargo
{
    public string Nome { get; }
    public int CargaHoraria { get; } // Horas/dia

    public Cargo(string nome, int cargaHoraria)
    {
        Nome = nome;
        CargaHoraria = cargaHoraria;
    }
}

public class Funcionario
{
    public string Nome { get; }
    public int Idade { get; }

    public string Cargo => _cargo.Nome; // É o mesmo que public string Cargo { get { return _cargo.Nome; } }
    public int CargaHoraria => _cargo.CargaHoraria;

    public string Rua => _endereco.Rua;
    public int Numero => _endereco.Numero;
    public string Bairro => _endereco.Bairro;
    public string Cidade => _endereco.Cidade;
    public string Estado => _endereco.Estado;
    public string Pais => _endereco.Pais;

    private Endereco _endereco;
    private Cargo _cargo;

    /* 
    * Esses construtores vão começar a parecer grandes demais... 
    * Para isso, existem outras técnicas, como uso de método de adição (ex.: AddCidade) ou 
    * o uso de factories.
    */
    public Funcionario(
        string nome,
        int idade,
        string nomeCargo,
        int cargaHoraria,
        string rua,
        int numero,
        string bairro,
        string nomeCidade,
        string estadoCidade,
        string paisCidade
    )
    {
        Nome = nome;
        Idade = idade;

        _cargo = new Cargo(nomeCargo, cargaHoraria);
        _endereco = new Endereco(rua, numero, bairro, nomeCidade, estadoCidade, paisCidade);
    }
}

class App
{
    static void Main()
    {
        Funcionario john = new Funcionario("John Doe", 32, "Analista de Sistemas", 8, "Av. Paulista", 1578, "Bela Vista", "São Paulo", "SP", "Brasil");
        Funcionario jane = new Funcionario("Jane Doe", 28, "Arquiteto de Software", 4, "Rua das Flores", 245, "Centro", "Curitiba", "PR", "Brasil");
        Funcionario mary = new Funcionario("Mary Monroe", 45, "Gerente de Projetos", 8, "Av. Goiás", 1001, "Setor Central", "Goiânia", "GO", "Brasil");

        ExibirFuncionario(john);
        ExibirFuncionario(jane);
        ExibirFuncionario(mary);
    }

    static void ExibirFuncionario(Funcionario func)
    {
        Console.WriteLine($"Funcionário: {func.Nome}");
        Console.WriteLine($"Idade: {func.Idade}");
        Console.WriteLine($"Cargo: {func.Cargo} ({func.CargaHoraria} horas/dia)");
        Console.WriteLine($"Endereço: {func.Rua}, {func.Numero}, Bairro {func.Bairro} - {func.Cidade}/{func.Estado} ({func.Pais})\n");
    }
}
