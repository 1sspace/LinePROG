using System;

class VolumeCalculator
{
    public double CalculateVolume(double a)
    {
        return Math.Pow(a, 3);
    }

    public double CalculateVolume(double a, double b, double c)
    {
        return a * b * c;
    }

    public double CalculateVolume(double r, double h, bool isCylinder)
    {
        return Math.PI * Math.Pow(r, 2) * h;
    }

    public double CalculateVolume(double r, bool isSphere)
    {
        return (4.0 / 3.0) * Math.PI * Math.Pow(r, 3);
    }
}

class Program
{
    static void Main(string[] args)
    {
        VolumeCalculator calc = new VolumeCalculator();

        Console.WriteLine($"Объем куба со стороной 2 равен {calc.CalculateVolume(2):F2}");
        Console.WriteLine($"Объем параллелепипеда со сторонами 2, 3 и 4 равен {calc.CalculateVolume(2, 3, 4):F2}");
        Console.WriteLine($"Объем цилиндра с радиусом 3 и высотой 5 равен {calc.CalculateVolume(3, 5, true):F2}");
        Console.WriteLine($"Объем шара с радиусом 3 равен {calc.CalculateVolume(3, true):F2}");

        Console.ReadLine();
    }
}