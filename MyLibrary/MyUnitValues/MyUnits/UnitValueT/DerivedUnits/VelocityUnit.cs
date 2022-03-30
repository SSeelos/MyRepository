using System;

namespace MyLibrary_DotNETstd_2_1
{

    public abstract class VelocityUnit : UnitValueT<Double>
    {
        public VelocityUnit(Double v) : base(v) { }
        public VelocityUnit(VelocityUnit v) : base(v) { }
        public VelocityUnit(Double l, double t) : base(l / t) { }
        public VelocityUnit(LengthUnit l, TimeUnit t) : base(l.BaseValue / t.BaseValue) { }
        public static MeterPerSecond operator +(VelocityUnit a, VelocityUnit b)
        {
            return new MeterPerSecond(a.BaseValue + b.BaseValue);

        }
        public static MeterPerSecond operator *(VelocityUnit a, VelocityUnit b)
        {
            return new MeterPerSecond(a.BaseValue + b.BaseValue);

        }
    }
    public class MeterPerSecond : VelocityUnit
    {
        public MeterPerSecond(Double v) : base(v) { }
        public MeterPerSecond(VelocityUnit vu) : base(vu) { }
        public MeterPerSecond(Double l, double t) : base(l, t) { }
        public MeterPerSecond(LengthUnit l, TimeUnit t) : base(l, t) { }

        public override double fromBaseUnit(double v)
        {
            return v;
        }

        public override double toBaseUnit(double v)
        {
            return v;
        }
    }
    public class KilometerPerHour : VelocityUnit
    {
        public KilometerPerHour(Double v) : base(v) { }
        public KilometerPerHour(VelocityUnit vu) : base(vu) { }
        public KilometerPerHour(Double l, double t) : base(l, t) { }
        public KilometerPerHour(LengthUnit l, TimeUnit t) : base(l, t) { }

        public override double fromBaseUnit(double v)
        {
            return v * 3.6;
        }

        public override double toBaseUnit(double v)
        {
            return v / 3.6;
        }
    }
}
