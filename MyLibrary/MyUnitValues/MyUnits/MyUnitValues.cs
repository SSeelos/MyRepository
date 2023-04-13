using System;
using System.Collections.Generic;

namespace MyLibrary_DotNETstd_2_1
{
    //extra class for each unit? -> convertToBase()
    public enum Units
    {
        none,

        mm,
        cm,
        m,

        s,
        min,
        h,
        d,

        EU,
        Cent,

        Celcius,
        Fahrenheit,
        Kelvin,

        Degree,
        Radians



    }


    public class DerivedUnitType
    {
        List<Units> top;
        List<Units> bottom;

        public void AddToTop(Units unit)
        {
            HandleAddingUnit(ref top, ref bottom, unit);
        }
        public void AddToBottom(Units unit)
        {
            HandleAddingUnit(ref bottom, ref top, unit);
        }
        private void HandleAddingUnit(ref List<Units> toList, ref List<Units> otherList, Units unit)
        {
            if (otherList.Contains(unit))
            {
                otherList.Remove(unit);
                return;
            }

            toList.Add(unit);
        }
        public override string ToString()
        {
            string toString = "";
            foreach (var item in top)
            {
                toString += item.ToString();
            }

            toString += "/";

            foreach (var item in bottom)
            {
                toString += item.ToString();
            }
            return toString;
        }
    }


    public static class UnitConverter
    {
        public static UnitValue Add(UnitValue a, UnitValue b)
        {
            try
            {
                if (a.Unit != b.Unit)
                    throw new Exception("cant add values of different units");

                return new UnitValue() { Unit = a.Unit, Value = a.Value + b.Value };

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return a;
            }
        }
        public static UnitValue Substract(UnitValue a, UnitValue b)
        {
            if (a.Unit != b.Unit)
                throw new Exception("cant subtract values of different units");

            return new UnitValue() { Unit = a.Unit, Value = a.Value - b.Value };
        }
        public static UnitValue Multiply(UnitValue a, UnitValue b)
        {
            //convert unit
            return new UnitValue() { Unit = a.Unit, Value = a.Value - b.Value };
        }

        internal static UnitValue Divide(UnitValue a, UnitValue b)
        {
            //convert unit
            return new UnitValue() { Unit = a.Unit, Value = a.Value / b.Value };
        }
    }

    public abstract class UnitType
    {
        public Units Unit => GetUnits();

        protected abstract Units GetUnits();

        public abstract double ConvertToBaseUnit(double value);
    }
    //public abstract class LengthUnit : UnitType
    //{
    //    /// <summary>
    //    /// Value of the base unit type
    //    /// </summary>
    //    public double BaseValue { get; protected set; }
    //    /// <summary>
    //    /// Value of this unit type
    //    /// </summary>
    //    public double DisplayValue { get { return this.DisplayValue; } set => OnSet(); }

    //    private void OnSet()
    //    {
    //        BaseValue = ConvertToBaseUnit(DisplayValue);
    //    }




    //    public LengthUnit(double displayValue)
    //    {
    //        this.DisplayValue = displayValue;
    //    }
    //    public static LengthUnit operator +(LengthUnit a, LengthUnit b)
    //    {
    //        return new Meter(a.DisplayValue + b.DisplayValue);
    //    }
    //}
    //public class Meter : LengthUnit
    //{
    //    public Meter(double displayValue)
    //        : base(displayValue)
    //    {
    //    }
    //    public override double ConvertToBaseUnit(double value)
    //    {
    //        return value;
    //    }

    //    protected override Units GetUnits()
    //    {
    //        return Units.m;
    //    }
    //}
    //public class MilliMeter : LengthUnit
    //{
    //    public MilliMeter(double displayValue)
    //        : base(displayValue)
    //    {
    //    }
    //    public override double ConvertToBaseUnit()
    //    {
    //        this.BaseValue = DisplayValue / 100;
    //    }

    //    protected override Units GetUnits()
    //    {
    //        return Units.mm;
    //    }
    //}
    //public class SquareMeter
    //{
    //    double Value;
    //    public SquareMeter(LengthUnit lengthA, LengthUnit lengthB)
    //    {
    //        this.Value = lengthA.BaseValue * lengthB.BaseValue;
    //    }
    //}
}
