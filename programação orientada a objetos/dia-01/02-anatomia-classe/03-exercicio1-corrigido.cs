// 1. Sistema de extrato bancário

using System;
using System.Collections.Generic;

public class Movimentacao
{
    public int Dia;
    public decimal Valor;
    public string Descricao;

    public Movimentacao(int dia, decimal valor, string descricao)
    {
        Dia = dia;
        Valor = valor;
        Descricao = descricao;
    }
}

public class MovimentacaoImpressao
{
    public string Dia;
    public string Operacao;
    public decimal Valor;
    public string Descricao;
    public decimal SaldoAcumulado;

    public MovimentacaoImpressao(string dia, string operacao, decimal valor, string descricao, decimal saldoAcumulado)
    {
        Dia = dia;
        Operacao = operacao;
        Valor = valor;
        Descricao = descricao;
        SaldoAcumulado = saldoAcumulado;
    }
}

public class ExtratoBancario
{
    private string CpfTitular;
    private string NomeTitular;
    private decimal SaldoInicial;
    private List<Movimentacao> Movimentacoes;
    private decimal SaldoFinal;
    private List<MovimentacaoImpressao> CacheMovimentacoesImpressao;

    public ExtratoBancario(string cpfTitular, string nomeTitular, decimal saldoInicial, List<Movimentacao> movimentacoes)
    {
        CpfTitular = cpfTitular;
        NomeTitular = nomeTitular;
        SaldoInicial = saldoInicial;
        Movimentacoes = movimentacoes;
        
        CacheMovimentacoesImpressao = new List<MovimentacaoImpressao>();
    }

    public void ApurarSaldoFinal()
    {
        decimal saldoAcumulado = SaldoInicial;

        for (int i = 0; i < Movimentacoes.Count; i++)
        {
            Movimentacao movimentacao = Movimentacoes[i];

            string operacao = movimentacao.Valor >= 0 ? "(+)" : "(-)";

            saldoAcumulado += movimentacao.Valor;

            CacheMovimentacoesImpressao.Add(
                new MovimentacaoImpressao(
                    $"Dia {movimentacao.Dia}",
                    operacao,
                    Math.Abs(movimentacao.Valor),
                    movimentacao.Descricao,
                    saldoAcumulado
                )
            );
        }

        SaldoFinal = saldoAcumulado;
    }

    public void ImprimirRelatorio()
    {
        ApurarSaldoFinal(); // Regra: garante que o saldo esteja calculado

        Console.WriteLine($"Extrato bancário de: {NomeTitular} (CPF: {CpfTitular})\n");
        Console.WriteLine($"Saldo inicial: R$ {SaldoInicial:F2}\n");

        for (int i = 0; i < CacheMovimentacoesImpressao.Count; i++)
        {
            MovimentacaoImpressao movimentacaoImpressao = CacheMovimentacoesImpressao[i];

            Console.WriteLine($"{movimentacaoImpressao.Dia}: {movimentacaoImpressao.Operacao} R$ {movimentacaoImpressao.Valor:F2} ({movimentacaoImpressao.Descricao}) - Acumulado R$ {movimentacaoImpressao.SaldoAcumulado:F2}");
        }

        Console.WriteLine($"\nSaldo final: R$ {SaldoFinal:F2}");
    }
}

class App
{
    static void Main()
    {
        List<Movimentacao> movimentacoes = new List<Movimentacao>
        {
            new Movimentacao(1, 200, "Depósito em conta"),
            new Movimentacao(2, -20, "Padaria"),
            new Movimentacao(3, 170, "Pix recebido"),
            new Movimentacao(4, -20, "Pix enviado"),
            new Movimentacao(5, 10, "Rendimentos conta"),
            new Movimentacao(5, 10, "Rendimentos investimento")
        };

        ExtratoBancario extrato = new ExtratoBancario("123.456.789-00", "John Doe", 1000, movimentacoes);

        extrato.ImprimirRelatorio();
    }
}
