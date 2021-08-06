using System;

namespace HSFunctionsStandard.Units
{

    public abstract class UnitValueT<T>
    {
        public UnitValueT(T v)
        {
            this._DisplayValue = v;
            this._BaseValue = this.toBaseUnit(v);
        }
        public UnitValueT(UnitValueT<T> v)
        {
            this._DisplayValue = this.fromBaseUnit(v.BaseValue);
            this.BaseValue = v.BaseValue;
        }


        private T _DisplayValue;
        private T _BaseValue;
        public T DisplayValue
        {
            get => this._DisplayValue;
            set
            {
                this._DisplayValue = value;
                this._BaseValue = this.toBaseUnit(value);
            }
        }
        public T BaseValue
        {
            get => this._BaseValue;
            set
            {
                this._DisplayValue = fromBaseUnit(value);
                this._BaseValue = value;
            }
        }

        public abstract T fromBaseUnit(T v);
        public abstract T toBaseUnit(T v);


    }



    public abstract class VelocityUnit : UnitValueT<Double>
    {
        public VelocityUnit(Double v) : base(v) { }
        public VelocityUnit(Double l, double t) : base(l / t) { }
        public VelocityUnit(LaengenUnit l, TimeUnit t) : base(l.BaseValue / t.BaseValue) { }
        public static MeterPerSecond operator +(VelocityUnit a, VelocityUnit b)
        {
            return new MeterPerSecond(a.BaseValue + b.BaseValue);

        }

    }
    public class MeterPerSecond : VelocityUnit
    {
        public MeterPerSecond(Double v) : base(v) { }
        public MeterPerSecond(Double l, double t) : base(l, t) { }
        public MeterPerSecond(LaengenUnit l, TimeUnit t) : base(l, t) { }

        public override double fromBaseUnit(double v)
        {
            return v;
        }

        public override double toBaseUnit(double v)
        {
            return v;
        }
    }
    public class KilometerPerSecond : VelocityUnit
    {
        public KilometerPerSecond(Double v) : base(v) { }
        public KilometerPerSecond(Double l, double t) : base(l, t) { }
        public KilometerPerSecond(LaengenUnit l, TimeUnit t) : base(l, t) { }

        public override double fromBaseUnit(double v)
        {
            return v * 3.6;
        }

        public override double toBaseUnit(double v)
        {
            return v / 3.6;
        }
    }

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
    public class Hour : TimeUnit
    {
        public Hour(Double v) : base(v) { }
        public Hour(TimeUnit v) : base(v) { }

        public override double fromBaseUnit(double v)
        {
            return v / 60;
        }

        public override double toBaseUnit(double v)
        {
            return v * 60;
        }

    }

    public abstract class LaengenUnit : UnitValueT<Double>
    {
        public LaengenUnit(Double v) : base(v) { }
        public LaengenUnit(LaengenUnit v) : base(v) { }
        public static Meter operator +(LaengenUnit a, LaengenUnit b)
        {
            return new Meter(a.BaseValue + b.BaseValue);





        }

    }


    public class km : LaengenUnit
    {

        public km(Double v) : base(v) { }
        public km(LaengenUnit v) : base(v) { }
        public override double fromBaseUnit(double v)
        {
            return v / 1000;
        }

        public override double toBaseUnit(double v)
        {
            return v * 1000;
        }
    }


    public class Meter : LaengenUnit
    {
        public Meter(Double v) : base(v) { }
        public Meter(LaengenUnit v) : base(v) { }

        public override double fromBaseUnit(double v)
        {
            return v;
        }

        public override double toBaseUnit(double v)
        {
            return v;
        }
    }

    public class mm : LaengenUnit
    {
        public mm(Double v) : base(v) { }
        public mm(LaengenUnit v) : base(v) { }

        public override double fromBaseUnit(double v)
        {
            return v * 1000;
        }

        public override double toBaseUnit(double v)
        {
            return v / 1000;
        }

    }

    public class cm : LaengenUnit
    {
        public cm(Double v) : base(v) { }
        public cm(LaengenUnit v) : base(v) { }

        public override double fromBaseUnit(double v)
        {
            return v * 100;
        }

        public override double toBaseUnit(double v)
        {
            return v / 100;
        }
    }
}
