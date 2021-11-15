using System;

namespace MyLibrary
{
    public struct UnitValue
    {
        public Units Unit;

        //public UnitType UnitType;
        public double Value;

        //public UnitValue(double value, Units unit = Units.none)
        //{
        //    Unit = unit;
        //    Value = value;
        //}

        public UnitValue(double value, Units unit)
        {
            Unit = unit;
            //UnitType = unit;
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
                    this.Unit = Units.mm;
                    value *= 10;
                    break;
                case Units.m:
                    this.Unit = Units.mm;
                    value *= 1000;
                    break;

                case Units.s:
                    break;
                case Units.min:
                    this.Unit = Units.s;
                    value *= 60;
                    break;
                case Units.h:
                    this.Unit = Units.s;
                    value *= 1440;
                    break;
                case Units.d:
                    this.Unit = Units.s;
                    value *= 86400;
                    break;

                case Units.EU:
                    break;
                case Units.Cent:
                    this.Unit = Units.EU;
                    value *= 0.01;
                    break;

                case Units.Celcius:
                    break;
                case Units.Fahrenheit:
                    this.Unit = Units.Celcius;
                    value += 32;
                    break;
                case Units.Kelvin:
                    this.Unit = Units.Celcius;
                    value += 273.15;
                    break;

                case Units.Degree:
                    break;
                case Units.Radians:
                    this.Unit = Units.Degree;
                    value *= 180 / Math.PI;
                    break;

                default:
                    break;
            }

            this.Value = value;
        }
        #endregion

        public override string ToString()
        {
            return Value.ToString() + " " + Unit.ToString();
        }

    }
}
