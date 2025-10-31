// 2. Formas geométricas

using System;

public class App
{
    static void Main()
    {
        Retangulo ret = new Retangulo(5.0, 3.0);
        Console.WriteLine($"Retângulo - Área: {ret.CalcularArea():F2}, Perímetro: {ret.CalcularPerimetro():F2}");

        Quadrado quad = new Quadrado(4.0);
        Console.WriteLine($"Quadrado - Área: {quad.CalcularArea():F2}, Perímetro: {quad.CalcularPerimetro():F2}");

        Circulo circ = new Circulo(2.5);
        Console.WriteLine($"Círculo - Área: {circ.CalcularArea():F2}, Perímetro: {circ.CalcularPerimetro():F2}");

        TrianguloEquilatero triEqui = new TrianguloEquilatero(5);
        Console.WriteLine($"Triângulo equilátero - Área: {triEqui.CalcularArea():F2}, Perímetro: {triEqui.CalcularPerimetro():F2}");

        TrianguloRetangulo triRet = new TrianguloRetangulo(3, 4);
        Console.WriteLine($"Triângulo retângulo - Área: {triRet.CalcularArea():F2}, Perímetro: {triRet.CalcularPerimetro():F2}");
    }
}

public abstract class FormaGeometrica
{
    public abstract double CalcularArea();
    public abstract double CalcularPerimetro();
}

public class Retangulo : FormaGeometrica
{
    private double Largura;
    private double Altura;

    public Retangulo(double largura, double altura)
    {
        Largura = largura;
        Altura = altura;
    }

    public override double CalcularArea()
    {
        return Largura * Altura;
    }

    public override double CalcularPerimetro()
    {
        return 2 * (Largura + Altura);
    }
}

public class Quadrado : FormaGeometrica
{
    private double Lado;

    public Quadrado(double lado)
    {
        Lado = lado;
    }

    public override double CalcularArea()
    {
        return Lado * Lado;
    }

    public override double CalcularPerimetro()
    {
        return 4 * Lado;
    }
}

public class Circulo : FormaGeometrica
{
    private double Raio;

    public Circulo(double raio)
    {
        Raio = raio;
    }

    public override double CalcularArea()
    {
        return Math.PI * Raio * Raio;
    }

    public override double CalcularPerimetro()
    {
        return 2 * Math.PI * Raio;
    }
}

public class TrianguloEquilatero : FormaGeometrica
{
    private double Lado;

    public TrianguloEquilatero(double lado)
    {
        Lado = lado;
    }

    public override double CalcularArea()
    {
        return Math.Sqrt(3) / 4 * Lado * Lado;
    }

    public override double CalcularPerimetro()
    {
        return 3 * Lado;
    }
}

public class TrianguloRetangulo : FormaGeometrica
{
    private double CatetoA;
    private double CatetoB;

    public TrianguloRetangulo(double a, double b)
    {
        CatetoA = a;
        CatetoB = b;
    }

    public override double CalcularArea()
    {
        return (CatetoA * CatetoB) / 2;
    }

    public override double CalcularPerimetro()
    {
        double hipotenusa = Math.Sqrt(CatetoA * CatetoA + CatetoB * CatetoB);

        return CatetoA + CatetoB + hipotenusa;
    }
}
