using System;

namespace MyLibrary_DotNETstd_2_1
{

    public abstract class TimeUnit : UnitValueT<double>
    {
        public TimeUnit(Double v) : base(v) { }
        public TimeUnit(TimeUnit v) : base(v) { }
        public static Second operator +(TimeUnit a, TimeUnit b)
        {
            return new Second(a.BaseValue + b.BaseValue);

            Second sec = new Second(5);
            var met = new Meter(5);
            MeterPerSecond mps = new MeterPerSecond(met, sec);
        }
    }
    public class Second : TimeUnit
    {
        public Second(Double v) : base(v) { }
        public Second(TimeUnit v) : base(v) { }

        public override double fromBaseUnit(double v)
        {
            return v;
        }

        public override double toBaseUnit(double v)
        {
            return v;
        }

    }
    public class Minute : TimeUnit
    {
        public Minute(Double v) : base(v) { }
        public Minute(TimeUnit v) : base(v) { }

        public override double fromBaseUnit(double v)
        {
            return v / 60;
        }

        public override double toBaseUnit(double v)
        {
            return v * 60;
        }

    }
    public class Hour : TimeUnit
    {
        public Hour(Double v) : base(v) { }
        public Hour(TimeUnit v) : base(v) { }

        public override double fromBaseUnit(double v)
        {
            return v / 3600;
        }

        public override double toBaseUnit(double v)
        {
            return v * 3600;
        }

    }
}
