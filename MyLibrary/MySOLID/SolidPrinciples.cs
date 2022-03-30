using System;
using System.Collections.Generic;
using System.Reflection;

namespace MyLibrary_DotNETstd_2_1
{
    //Single Responsibility Principle   (S-RP)
    //modules should have only one reason to change
    //-> separate concerns

    //Open closed Principle             (O-CP)
    //module/class is open for extension and closed for modification
    //-> introduce interfaces (or abstract class)

    //Liskov Substitution Principle     (L-SP)
    //be able to use any derived class instead of a parent class

    //Interface Segregation Principle   (I-SP)
    //clients should not be forced to implement interfaces they don't use
    //-> many small interfaces based on groups of methods

    //Dependency Inversion Principle    (D-IP)
    //high-level modules/classes should not depend on low-level modules/classes
    //-> both dependant on abstractions, avoid coupling
    //abstractions should not depend on details
    //-> details dependant on abstractions

    //Dependency Injection (DI)
    //common way to implement DIP
    //-> object receives other objects that it depends on (dependencies)
    public interface IShape
    {
        public static class Factory        //(DIP)
        {
            public static ILine CreateLine(double x)
            {
                return new Line(x);
            }
            public static ISquare CreateSquare()
            {
                return new Square();
            }
            public static IShape2D CreateCircle()
            {
                return new Circle();
            }
            public static IShape2D CreateHollowCircle(double radius, double innerRadius)
            {
                return new HollowCircle(radius, innerRadius);
            }
            //public static IShape CreateCube()
            //{
            //    return new Cube();
            //}
        }
    }
    public interface IShape1D : IShape
    {
        double DimX { get; }
    }
    public interface IShape2D : IShape1D        //(ISP)
    {
        double DimY { get; }
        double Area();
    }
    public interface IShape3D : IShape2D        //(ISP)
    {
        double DimZ { get; }
        double Volume();
    }

    public interface ILine : IShape1D
    {
    }

    public class Line : ILine
    {
        public double DimX { get; set; }

        public Line(double length)
        {
            this.DimX = length;
        }
    }

    public interface ISquare : IShape2D
    {
    }

    public class Square : ISquare
    {
        private double _dimX;
        public double DimX
        {
            get => _dimX; set
            {
                _dimX = value;
                _dimY = value;
            }
        }
        private double _dimY;
        public double DimY
        {
            get => _dimY; set
            {
                _dimY = value;
                _dimX = value;
            }
        }

        public double Area()
        {
            return Math.Pow(this.DimX, 2);
        }

    }

    public class Circle : IShape2D
    {
        private double _radius;
        public double Radius { get => _radius; set => SetRadius(value); }

        private void SetRadius(double value)
        {
            _radius = value;
            _dimX = value / 2;
            _dimY = value / 2;
        }

        private double _dimX;
        public double DimX { get => _dimX; set => SetDimX(value); }

        private void SetDimX(double value)
        {
            _dimX = value;
            _dimY = value;
            _radius = value / 2;
        }
        private double _dimY;
        public double DimY { get => _dimY; set => SetDimY(value); }

        private void SetDimY(double value)
        {
            _dimY = value;
            _dimX = value;
            _radius = value / 2;
        }

        public double Area()
        {
            return Math.PI * Math.Pow(this._radius, 2);
        }
    }
    public class HollowCircle : Circle
    {
        public double InnerRadius;
        public HollowCircle(double radius, double innerRadius)
        {
            this.Radius = radius;
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
        public double DimX { get; private set; }
        public double DimY { get; private set; }
        public double DimZ { get; private set; }
        private double _length;
        public double Length
        {
            get => _length; set
            {
                _length = value;
                DimX = value;
                DimY = value;
                DimZ = value;
            }
        }

        public Cube(double length)
        {
            this.Length = length;
        }


        public double Area()
        {
            return Math.Pow(this.Length, 2);
        }


        public double Volume()
        {
            return Math.Pow(this.Length, 3);
        }
    }


    public interface ICalculator                        //(DIP)
    {
        List<double> Sum();
        double Output();
    }
    public class LengthCalculator : ICalculator            //(SRP)
    {
        protected IShape1D[] shapes;

        public LengthCalculator(params IShape1D[] shapes)
        {
            this.shapes = shapes;
        }

        public List<double> Sum()
        {
            var area = new List<double>();
            foreach (var shape in shapes)
            {
                area.Add(shape.DimX);         //(OCP) removes the need for a switch statement, that would have to be extendet
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
    public class AreaCalculator : ICalculator            //(SRP)
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
                area.Add(shape.Area());         //(OCP)
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
    public class VolumeCalculator : ICalculator            //(SRP)
    {
        protected IShape3D[] shapes;

        public VolumeCalculator(params IShape3D[] shapes)
        {
            this.shapes = shapes;
        }

        public List<double> Sum()
        {
            var area = new List<double>();
            foreach (var shape in shapes)
            {
                area.Add(shape.Volume());         //(OCP)
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

    public class CalculatorOutputter        //(SRP)
    {
        protected ICalculator calculator;   //(DIP)
        public CalculatorOutputter(ICalculator calculator)
        {
            this.calculator = calculator;
        }

        public void OutputVariant_1()
        {
            Console.WriteLine(MethodBase.GetCurrentMethod().Name);
            foreach (var item in calculator.Sum())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(calculator.Output());
        }
        public void OutputVariant_2()
        {
            Console.WriteLine(MethodBase.GetCurrentMethod().Name);
            foreach (var item in calculator.Sum())
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Sum: " + calculator.Output());
        }
    }
}
