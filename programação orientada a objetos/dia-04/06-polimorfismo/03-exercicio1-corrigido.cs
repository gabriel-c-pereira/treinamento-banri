// 1. Sistema de reservas de hospedagem

using System;

public class Reserva
{
    private static string NOME_CLIENTE_PENDENTE = "A definir";
    private static int DIAS_PADRAO = 2;
    private static string STATUS_CONFIRMADA = "CONFIRMADA";
    private static string STATUS_PENDENTE = "PENDENTE";

    public string NomeCliente { get; private set; }
    public int NumeroQuarto { get; private set; }
    public int NumeroDias { get; private set; }
    public decimal ValorDiaria { get; private set; }
    public decimal ValorTotal { get { return NumeroDias * ValorDiaria; } }
    public string Status { get; private set; }

    public Reserva(string nomeCliente, int numeroQuarto, int numeroDias, decimal valorDiaria)
    {
        NomeCliente = nomeCliente;
        NumeroQuarto = numeroQuarto;
        NumeroDias = numeroDias;
        ValorDiaria = valorDiaria;
        Status = STATUS_CONFIRMADA;
        
        Console.WriteLine("Reserva completa criada com sucesso!");
    }

    public Reserva(string nomeCliente, int numeroQuarto, decimal valorDiaria)
    {
        NomeCliente = nomeCliente;
        NumeroQuarto = numeroQuarto;
        NumeroDias = DIAS_PADRAO;
        ValorDiaria = valorDiaria;
        Status = STATUS_CONFIRMADA;

        Console.WriteLine("Reserva parcial criada com sucesso!");
    }

    public Reserva(int numeroQuarto, decimal valorDiaria)
    {
        NomeCliente = NOME_CLIENTE_PENDENTE;
        NumeroQuarto = numeroQuarto;
        NumeroDias = DIAS_PADRAO;
        ValorDiaria = valorDiaria;
        Status = STATUS_PENDENTE;

        Console.WriteLine("Reserva mínima criada com sucesso!");
    }

    public void ExibirResumo()
    {
        Console.WriteLine($"\nCliente: {NomeCliente}");
        Console.WriteLine($"Quarto: {NumeroQuarto}");
        Console.WriteLine($"Número de dias: {NumeroDias}");
        Console.WriteLine($"Valor da diária: R$ {ValorDiaria:F2}");
        Console.WriteLine($"Valor total: R$ {ValorTotal:F2}");
        Console.WriteLine($"Status: {Status}\n");
    }
}

class App
{
    static void Main()
    {
        Reserva reservaCompleta = new Reserva("John Doe", 305, 5, 250m);
        reservaCompleta.ExibirResumo();

        Reserva reservaMinima = new Reserva(102, 180m);
        reservaMinima.ExibirResumo();
    }
}
