using System;

abstract class Shape
{
    public abstract double GetVolume();
}

class Cube : Shape
{
    public double Side { get; set; }

    public Cube(double side)
    {
        Side = side;
    }

    public override double GetVolume()
    {
        return Math.Pow(Side, 3);
    }
}

class Parallelepiped : Shape
{
    public double A { get; set; }
    public double B { get; set; }
    public double C { get; set; }

    public Parallelepiped(double a, double b, double c)
    {
        A = a;
        B = b;
        C = c;
    }

    public override double GetVolume()
    {
        return A * B * C;
    }
}

class Cylinder : Shape
{
    public double Radius { get; set; }
    public double Height { get; set; }

    public Cylinder(double r, double h)
    {
        Radius = r;
        Height = h;
    }

    public override double GetVolume()
    {
        return Math.PI * Math.Pow(Radius, 2) * Height;
    }
}

class Sphere : Shape
{
    public double Radius { get; set; }

    public Sphere(double r)
    {
        Radius = r;
    }

    public override double GetVolume()
    {
        return (4.0 / 3.0) * Math.PI * Math.Pow(Radius, 3);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Shape cube = new Cube(2);
        Shape para = new Parallelepiped(2, 3, 4);
        Shape cyl = new Cylinder(3, 5);
        Shape sphere = new Sphere(3);

        Console.WriteLine($" объем куба со стороной 2  {cube.GetVolume():F2}");
        Console.WriteLine($"объем параллелепипеда со сторонами 2 3 и 4 равен {para.GetVolume():F2}");
        Console.WriteLine($"объем цилиндра с радиусом 3 и высотой 5 равен {cyl.GetVolume():F2}");
        Console.WriteLine($"объем шара с радиусом 3 равен {sphere.GetVolume():F2}");

        Console.ReadLine();
    }
}