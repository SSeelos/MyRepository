using System;

namespace MyLibrary_DotNETstd_2_1
{
    public abstract class LengthUnit : UnitValueT<Double>
    {
        public LengthUnit(Double v) : base(v) { }
        public LengthUnit(LengthUnit v) : base(v) { }
        public static Meter operator +(LengthUnit a, LengthUnit b)
        {
            return new Meter(a.BaseValue + b.BaseValue);


        }

    }



    public class Meter : LengthUnit
    {
        public Meter(Double v) : base(v) { }
        public Meter(LengthUnit v) : base(v) { }

        public override double fromBaseUnit(double v)
        {
            return v;
        }

        public override double toBaseUnit(double v)
        {
            return v;
        }
    }
    public class Centimeter : LengthUnit
    {
        public Centimeter(Double v) : base(v) { }
        public Centimeter(LengthUnit v) : base(v) { }

        public override double fromBaseUnit(double v)
        {
            return v * 100;
        }

        public override double toBaseUnit(double v)
        {
            return v / 100;
        }
    }

    public class Millimeter : LengthUnit
    {
        public Millimeter(Double v) : base(v) { }
        public Millimeter(LengthUnit v) : base(v) { }

        public override double fromBaseUnit(double v)
        {
            return v * 1000;
        }

        public override double toBaseUnit(double v)
        {
            return v / 1000;
        }

    }

    public class Kilometer : LengthUnit
    {

        public Kilometer(Double v) : base(v) { }
        public Kilometer(LengthUnit v) : base(v) { }
        public override double fromBaseUnit(double v)
        {
            return v / 1000;
        }

        public override double toBaseUnit(double v)
        {
            return v * 1000;
        }
    }

}
