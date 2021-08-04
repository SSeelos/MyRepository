using System;

namespace MyLibrary
{
    public class UnitValuesProgram
    {
        public UnitValuesProgram()
        {
            Run();
        }

        private void Run()
        {
            var valueA = new UnitValue(2, Units.m);
            var valueB = new UnitValue(3, Units.m);

            UnitValue sum = valueA + 1;

            Console.WriteLine(string.Format("Add: {0} {1}", valueA + valueB, valueA.Unit));
            Console.WriteLine(string.Format("A-B: {0} {1}", valueA - valueB, valueA.Unit));
            Console.WriteLine(string.Format("B-A: {0} {1}", valueB - valueA, valueA.Unit));

            valueA = new UnitValue(1, Units.m);
            valueB = new UnitValue(1, Units.mm);


            Console.WriteLine(valueA + valueB);
        }
    }
}
