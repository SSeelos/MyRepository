namespace MyLibrary
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






}
