using System;
using System.Collections.Generic;
using System.Reflection;

namespace MyLibrary
{
    //Single Responsibility Principle (S-RP)
    //modules should have only one reason to change
    //-> separate concerns

    //Open closed Principle (O-CP)
    //module/class is open for extension and closed for modification
    //-> introduce interfaces (or abstract class)

    //Liskov Substitution Principle (L-SP)
    //be able to use any derived class instead of a parent class

    //Interface Segregation Principle (ISP)
    //clients should not be forced to implement interfaces they don't use
    //-> many small interfaces based on groups of methods

    public interface IShape1D
    {
        double DimX();
    }
    public interface IShape2D : IShape1D        //(ISP)
    {
        double Area();
    }
    public interface IShape3D : IShape2D        //(ISP)
    {
        double Volume();
    }
    public class Line : IShape1D
    {
        public double Lenght;

        public Line(double lenght)
        {
            this.Lenght = lenght;
        }

        public double DimX()
        {
            return this.Lenght;
        }
    }
    public class Square : IShape2D
    {
        public double Length;

        public Square(double lenght)
        {
            this.Length = lenght;
        }

        public double DimX()
        {
            return this.Length;
        }
        public double Area()
        {
            return Math.Pow(this.Length, 2);
        }

    }

    public class Circle : IShape2D
    {
        public double Radius;
        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double DimX()
        {
            return this.Radius * 2;
        }
        public double Area()
        {
            return Math.PI * Math.Pow(this.Radius, 2);
        }
    }
    public class HollowCircle : Circle
    {
        public double InnerRadius;
        public HollowCircle(double radius, double innerRadius)
            : base(radius)
        {
            this.InnerRadius = innerRadius;
        }

        public new double Area()      //(LSP)
        {
            var outerArea = Math.PI * Math.Pow(this.Radius, 2);
            var innerArea = Math.PI * Math.Pow(this.InnerRadius, 2);
            return outerArea - innerArea;
        }
    }

    public class Cube : IShape3D
    {
        public double Length;

        public Cube(double length)
        {
            this.Length = length;
        }
        public double Area()
        {
            return Math.Pow(this.Length, 2);
        }

        public double DimX()
        {
            return this.Length;
        }

        public double Volume()
        {
            return Math.Pow(this.Length, 3);
        }
    }

    public class AreaCalculator             //(SRP)
    {
        protected IShape2D[] shapes;

        public AreaCalculator(params IShape2D[] shapes)
        {
            this.shapes = shapes;
        }

        public List<double> Sum()
        {
            var area = new List<double>();
            foreach (var shape in shapes)
            {
                area.Add(shape.Area());     //(OCP) removes the need for a switch statement, that would have to be extendet
            }
            return area;

        }

        public double Output()
        {
            double sum = 0;

            foreach (var item in Sum())
            {
                sum += item;
            }

            return sum;
        }
    }

    public class AreaCalculatorOutputter    //(SRP)
    {
        protected AreaCalculator areaCalculator;
        public AreaCalculatorOutputter(AreaCalculator areaCalculator)
        {
            this.areaCalculator = areaCalculator;
        }

        public void OutputVariant_1()
        {
            Console.WriteLine(MethodBase.GetCurrentMethod().Name);
            foreach (var item in areaCalculator.Sum())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(areaCalculator.Output());
        }
        public void OutputVariant_2()
        {
            Console.WriteLine(MethodBase.GetCurrentMethod().Name);
            foreach (var item in areaCalculator.Sum())
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Sum: " + areaCalculator.Output());
        }
    }
}
