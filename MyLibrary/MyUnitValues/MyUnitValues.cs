using System;
using System.Collections.Generic;

namespace MyLibrary
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
        Kelvin



    }


    public class UnitType
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

    public static class UnitProcessor
    {
        public static Dictionary<Units, Dictionary<Units, Func<Units>>> unitsDict = new Dictionary<Units, Dictionary<Units, Func<Units>>>();

        public static void Init()
        {
            Func<double, UnitValue> convert = Convert_mm;
            var mmDict = new Dictionary<Units, Func<double, UnitValue>>();
            mmDict.Add(Units.m, Convert_mm(1));
            unitsDict.Add(Units.mm)
        }

        public delegate Units Convert();

        public static UnitValue Convert_mm(double b)
        {
            var uv = new UnitValue()
            {
                Unit = Units.mm,
                Value = b * 1000

            };

            return uv;
        }

    }

    public static class UnitConverter
    {
        public static UnitValue Add(UnitValue a, UnitValue b)
        {
            if (a.Unit != b.Unit)
                throw new Exception("cant add values of different units");

            return new UnitValue() { Unit = a.Unit, Value = a.Value + b.Value };
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
    public struct UnitValue
    {
        public Units Unit;
        public double Value;

        public UnitValue(double value, Units unit = Units.none)
        {
            Unit = unit;
            Value = value;
        }

        #region Operators
        public static UnitValue operator +(UnitValue a, double b)
        {
            return new UnitValue() { Unit = a.Unit, Value = a.Value + b };
        }
        public static UnitValue operator -(UnitValue a, double b)
        {
            return new UnitValue() { Unit = a.Unit, Value = a.Value - b };
        }
        public static UnitValue operator *(UnitValue a, double b)
        {
            return new UnitValue() { Unit = a.Unit, Value = a.Value * b };
        }
        public static UnitValue operator /(UnitValue a, double b)
        {
            return new UnitValue() { Unit = a.Unit, Value = a.Value / b };
        }
        public static UnitValue operator +(UnitValue a, UnitValue b)
        {
            return UnitConverter.Add(a, b);
        }
        public static UnitValue operator -(UnitValue a, UnitValue b)
        {
            return UnitConverter.Substract(a, b);
        }
        public static UnitValue operator *(UnitValue a, UnitValue b)
        {
            return UnitConverter.Multiply(a, b);
        }
        public static UnitValue operator /(UnitValue a, UnitValue b)
        {
            return UnitConverter.Divide(a, b);
        }

        #endregion

        #region Conversions

        public void ConvertToBaseUnit()
        {
            var value = this.Value;

            switch (this.Unit)
            {
                case Units.none:
                    break;
                case Units.mm:
                    break;
                case Units.cm:
                    value *= 10;
                    break;
                case Units.m:
                    value *= 1000;
                    break;
                case Units.s:
                    break;
                case Units.min:
                    value *= 60;
                    break;
                case Units.h:
                    value *= 1440;
                    break;
                case Units.d:
                    value *= 86400;
                    break;
                case Units.EU:
                    break;
                case Units.Cent:
                    value *= 0.01;
                    break;
                case Units.Celcius:
                    break;
                case Units.Fahrenheit:
                    value += 32;
                    break;
                case Units.Kelvin:
                    value += 273.15;
                    break;

                default:
                    break;
            }

            this.Value = value;
        }
        #endregion

        public override string ToString()
        {
            return Value.ToString() + Unit.ToString();
        }

    }
}
