using System;

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
    }
}

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

public class ValidadorCPF
{
    public static bool IsValid(string cpf)
    {
        // Não é necessário implementar essa validação
        return true;
    }
}

public class ValidadorCNPJ
{
    public static bool IsValid(string cnpj)
    {
        // Não é necessário implementar essa validação
        return true;
    }
}
