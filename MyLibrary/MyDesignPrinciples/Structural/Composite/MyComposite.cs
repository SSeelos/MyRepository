using MyLibrary.MyUtilities;
using System.Collections.Generic;
using System.Reflection;

namespace MyLibrary.MyDesignPrinciples.Composite
{
    public interface IComponent
    {
        void Execute();
    }

    public class MyComposite:IComponent
    {
        private List<IComponent> components = new List<IComponent>();

        public void Add(IComponent component)
        {
            components.Add(component);
        }
        public void Remove(IComponent component)
        {
            if (components.Contains(component))
                components.Remove(component);
        }

        public List<IComponent> GetChildren()
        {
            return components;
        }

        public void Execute()
        {
            foreach (var component in components)
            {
                component.Execute();
            }
        }
    }

    public class MyLeaf : IComponent
    {
        public void Execute()
        {
            MyConsoleLogger.Instance.ClassMethodLog(this.GetType(), MethodBase.GetCurrentMethod());
        }
    }
}
