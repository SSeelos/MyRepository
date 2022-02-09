namespace MyConsoleAppProject
{
    public abstract class MyAbstractClass
    {
        public static string _myStaticProperty;
        //only accessible from this class
        private string myField;

        //only accessible from derived classes
        protected string myProtectedVariable;

        public MyAbstractClass(string field)
        {
            this.myField = field;
        }

        //derived classes can override virtual method
        public virtual void MyVirtualMethod()
        {
            //default implementation
        }

        //derived classes must override abstract method
        public abstract void MyAbstractMethod();
    }
}
