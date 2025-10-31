// 1. Sistema de entregas

using System;

public abstract class Entrega
{
    private static int contadorPedidos = 10000;

    public int NumeroPedido { get; }
    public decimal PesoEmKg { get; }

    public Entrega(decimal pesoEmKg)
    {
        NumeroPedido = contadorPedidos++;
        PesoEmKg = pesoEmKg;
    }

    public abstract decimal CalcularFrete();
}

public class EntregaEconomica : Entrega
{
    public EntregaEconomica(decimal pesoEmKg) : base(pesoEmKg) { }

    public override decimal CalcularFrete()
    {
        return PesoEmKg * 5m;
    }
}

public class EntregaExpressa : Entrega
{
    public string RegiaoOrigem { get; }
    public string RegiaoDestino { get; }

    public EntregaExpressa(decimal pesoEmKg, string regiaoOrigem, string regiaoDestino) : base(pesoEmKg)
    {
        RegiaoOrigem = regiaoOrigem;
        RegiaoDestino = regiaoDestino;
    }

    public override decimal CalcularFrete()
    {
        decimal valorBase = PesoEmKg * 7m;
        
        decimal taxaExtra = RegiaoOrigem != RegiaoDestino ? 10m : 0m;

        return valorBase + taxaExtra;
    }
}

public class EntregaInternacional : Entrega
{
    public string PaisOrigem { get; }
    public string PaisDestino { get; }

    public EntregaInternacional(decimal pesoEmKg, string paisOrigem, string paisDestino) : base(pesoEmKg)
    {
        PaisOrigem = paisOrigem;
        PaisDestino = paisDestino;
    }

    public override decimal CalcularFrete()
    {
        decimal valorBase = PesoEmKg * 12m;
        decimal taxaExtra = 0m;

        if (PaisOrigem == "Estados Unidos" || PaisDestino == "Estados Unidos")
            taxaExtra = 40m;
        else if (PaisOrigem != PaisDestino)
            taxaExtra = 20m;

        return valorBase + taxaExtra;
    }
}

class App
{
    static void Main()
    {
        Entrega economica = new EntregaEconomica(2.5m);
        Entrega expressa = new EntregaExpressa(3m, "Sul", "Sudeste");
        Entrega internacional = new EntregaInternacional(1.2m, "Brasil", "Estados Unidos");

        Console.WriteLine($"Entrega Econômica (Pedido {economica.NumeroPedido}): R$ {economica.CalcularFrete():F2}");
        Console.WriteLine($"Entrega Expressa (Pedido {expressa.NumeroPedido}): R$ {expressa.CalcularFrete():F2}");
        Console.WriteLine($"Entrega Internacional (Pedido {internacional.NumeroPedido}): R$ {internacional.CalcularFrete():F2}");
    }
}
