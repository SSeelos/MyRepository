namespace MyConsoleAppProject
{

    /// <summary>
    ///An immutable type is a type of which its properties can only be set at initialization.

    ///Note that private set only provides a restricted encapsulation
    ///of change to the property from within the same class,
    ///and thus isn't truly immutable
    /// </summary>
    public class MyImmutableObject
    {
        private readonly string _immutableProperty;
        public string ImmutableProperty => _immutableProperty;

        public MyImmutableObject(string prop)
        {
            _immutableProperty = prop;
        }

        //in C#6 and later,
        //getter-only auto properties have now been implemented,
        //which allows for immutable auto-properties
        //without the need for the additional explicit private readonly backing field
        public string MyGetterOnlyAutoProperty { get; }

        public MyImmutableObject(string prop, string autoprop)
        {
            _immutableProperty = prop;

            // The compiler understands this and initializes the backing field
            MyGetterOnlyAutoProperty = autoprop;
        }
    }
}
