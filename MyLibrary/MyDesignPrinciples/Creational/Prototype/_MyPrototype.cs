namespace MyLibrary_DotNETstd_2_1.MyDesignPrinciples.Prototype
{
    public interface IPrototype
    {
        _MyPrototype Clone();
    }
    public abstract class _MyPrototype : IPrototype
    {
        protected string field;

        public _MyPrototype(string field)
        {
            this.field = field;
        }
        public _MyPrototype(_MyPrototype prototype)
        {
            this.field = prototype.field;
        }

        public abstract _MyPrototype Clone();

        public virtual string Output() => $"{this.GetType().Name}: {this.field}";
    }
}
