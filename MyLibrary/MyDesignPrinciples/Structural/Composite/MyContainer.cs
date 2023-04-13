using MyLibrary_DotNETstd_2_1.MyUtilities;
using System.Collections.Generic;
using System.Reflection;

namespace MyLibrary_DotNETstd_2_1.MyDesignPrinciples.Composite
{
    /// <summary>
    /// describes operations that are common to both 
    /// simple and complex elements of the tree
    /// </summary>
    public interface IComponent
    {
        void Execute();
    }

    /// <summary>
    /// has sub-elements: leaves or other containers (aka composits)
    /// </summary>
    public class MyContainer : IComponent
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

    /// <summary>
    /// basic element of a tree that doesn’t have sub-elements
    /// </summary>
    public class MyLeaf : IComponent
    {
        public void Execute()
        {
            MyConsoleLogger.Instance.ClassMethodLog(this.GetType(), MethodBase.GetCurrentMethod());
        }
    }
}
