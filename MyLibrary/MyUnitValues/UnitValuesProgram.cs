using System;
using System.Reflection;

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
            RunUnitValue();

            RunUnitValueT();
        }

        private void RunUnitValue()
        {
            Console.WriteLine(MethodBase.GetCurrentMethod().Name);
            Console.WriteLine();

            var valueA = new UnitValue(2, Units.m);
            var valueB = new UnitValue(3, Units.m);

            UnitValue sum = valueA + 1;

            Console.WriteLine(string.Format("Add: {0} {1}", valueA + valueB, valueA.Unit));
            Console.WriteLine(string.Format("A-B: {0} {1}", valueA - valueB, valueA.Unit));
            Console.WriteLine(string.Format("B-A: {0} {1}", valueB - valueA, valueA.Unit));

            var angleA = new UnitValue(90, Units.Degree);
            var angleB = new UnitValue(3, Units.Radians);
            angleB.ConvertToBaseUnit();

            UnitValue angleSum = angleA + angleB;

            Console.WriteLine(string.Format("AddAngle: {0}", angleSum));

            valueA = new UnitValue(1, Units.m);
            valueB = new UnitValue(1, Units.mm);


            Console.WriteLine(valueA + valueB);

        }
        private void RunUnitValueT()
        {
            Console.WriteLine(MethodBase.GetCurrentMethod().Name);
            Console.WriteLine();

            Meter meter = new Meter(2);
            Centimeter centimeter = new Centimeter(100);



            Meter add = meter + centimeter;

            var hour = new Hour(1);

            var mps = new MeterPerSecond(meter, hour);

            Console.WriteLine(string.Format("MPS: {0} BaseValue= {1} DisplayValue{2}",
                mps.GetType().Name,
                mps.BaseValue,
                mps.DisplayValue));

            var kmph = new KilometerPerHour(meter, hour);

            Console.WriteLine(string.Format("MPS: {0} BaseValue= {1} DisplayValue{2}",
                kmph.GetType().Name,
                kmph.BaseValue,
                kmph.DisplayValue));

            var kmphFromMps = new KilometerPerHour(mps);

            Console.WriteLine(string.Format("MPS: {0} BaseValue= {1} DisplayValue{2}",
                kmph.GetType().Name,
                kmph.BaseValue,
                kmph.DisplayValue));


        }
    }
}
