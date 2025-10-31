// 1. Pix entre diferentes tipos de pessoas

using System;

public abstract class Pix
{
    protected string _idOriginador;
    protected string _idDestinatario;
    protected double _valor;

    public abstract string Executar();

    public void ImprimirComprovante()
    {
        Console.WriteLine($"Pix de R$ {_valor:F2} enviado de {_idOriginador} para {_idDestinatario}.");
    }
}

public class PixPessoaFisica : Pix
{
    public PixPessoaFisica(string cpfOriginador, string cpfDestinatario, double valor)
    {
        _idOriginador = cpfOriginador;
        _idDestinatario = cpfDestinatario;
        _valor = valor;
    }

    public override string Executar()
    {
        if (!ValidadorCPF.IsValid(_idOriginador))
            return "Originador inválido!";
        if (!ValidadorCPF.IsValid(_idDestinatario))
            return "Destinatário inválido!";
        if (_valor <= 0)
            return "Valor do pix deve ser positivo!";

        return $"Pix de R$ {_valor:F2} enviado de {_idOriginador} para {_idDestinatario}.";
    }
}

public class PixPessoaJuridica : Pix
{
    public PixPessoaJuridica(string cnpjOriginador, string cnpjDestinatario, double valor)
    {
        _idOriginador = cnpjOriginador;
        _idDestinatario = cnpjDestinatario;
        _valor = valor;
    }

    public override string Executar()
    {
        if (!ValidadorCNPJ.IsValid(_idOriginador))
            return "Originador inválido!";
        if (!ValidadorCNPJ.IsValid(_idDestinatario))
            return "Destinatário inválido!";
        if (_valor <= 0)
            return "Valor do pix deve ser positivo!";

        return $"Pix de R$ {_valor:F2} enviado de {_idOriginador} para {_idDestinatario}.";
    }
}

public class PixPessoaFisicaJuridica : Pix
{
    public PixPessoaFisicaJuridica(string cpfOriginador, string cnpjDestinatario, double valor)
    {
        _idOriginador = cpfOriginador;
        _idDestinatario = cnpjDestinatario;
        _valor = valor;
    }

    public override string Executar()
    {
        if (!ValidadorCPF.IsValid(_idOriginador))
            return "Originador inválido!";
        if (!ValidadorCNPJ.IsValid(_idDestinatario))
            return "Destinatário inválido!";
        if (_valor <= 0)
            return "Valor do pix deve ser positivo!";

        return $"Pix de R$ {_valor:F2} enviado de {_idOriginador} para {_idDestinatario}.";
    }
}

public class PixPessoaJuridicaFisica : Pix
{
    public PixPessoaJuridicaFisica(string cnpjOriginador, string cpfDestinatario, double valor)
    {
        _idOriginador = cnpjOriginador;
        _idDestinatario = cpfDestinatario;
        _valor = valor;
    }

    public override string Executar()
    {
        if (!ValidadorCNPJ.IsValid(_idOriginador))
            return "Originador inválido!";
        if (!ValidadorCPF.IsValid(_idDestinatario))
            return "Destinatário inválido!";
        if (_valor <= 0)
            return "Valor do pix deve ser positivo!";

        return $"Pix de R$ {_valor:F2} enviado de {_idOriginador} para {_idDestinatario}.";
    }
}

public class ValidadorCPF
{
    public static bool IsValid(string cpf)
    {
        return true;
    }
}

public class ValidadorCNPJ
{
    public static bool IsValid(string cnpj)
    {
        return true;
    }
}

public class App
{
    static void Main()
    {
        PixPessoaFisica pfPf = new PixPessoaFisica("123.456.789-00", "987.654.321-00", 150.0);
        Console.WriteLine(pfPf.Executar());
        pfPf.ImprimirComprovante();

        PixPessoaJuridica pjPj = new PixPessoaJuridica("12.345.678/0001-00", "98.765.432/0001-00", 500.0);
        Console.WriteLine(pjPj.Executar());
        pjPj.ImprimirComprovante();

        PixPessoaFisicaJuridica pfPj = new PixPessoaFisicaJuridica("123.456.789-00", "12.345.678/0001-00", 200.0);
        Console.WriteLine(pfPj.Executar());
        pfPj.ImprimirComprovante();

        PixPessoaJuridicaFisica pjPf = new PixPessoaJuridicaFisica("12.345.678/0001-00", "987.654.321-00", 300.0);
        Console.WriteLine(pjPf.Executar());
        pjPf.ImprimirComprovante();
    }
}
