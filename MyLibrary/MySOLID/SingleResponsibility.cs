using System;
using System.Collections.Generic;
using System.Reflection;

namespace MyLibrary
{
    public interface IShape { }
    public class Square : IShape
    {
        public double Lenght;

        public Square(double lenght)
        {
            this.Lenght = lenght;
        }
    }

    public class Circle : IShape
    {
        public double Radius;
        public Circle(double radius)
        {
            this.Radius = radius;
        }
    }

    public class AreaCalculator
    {
        protected IShape[] shapes;

        public AreaCalculator(params IShape[] shapes)
        {
            this.shapes = shapes;
        }

        public List<double> Sum()
        {
            var area = new List<double>();
            foreach (var shape in shapes)
            {
                switch (shape)
                {
                    case Square square:
                        area.Add(Math.Pow(square.Lenght, 2));
                        break;
                    case Circle circle:
                        area.Add(Math.PI * Math.Pow(circle.Radius, 2));
                        break;

                    default:
                        break;

                }
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

    public class AreaCalculatorOutputter
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
