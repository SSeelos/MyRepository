using System;

namespace MyLibrary_DotNETstd_2_1.MyDesignPrinciples.Composite
{
    /// <summary>
    /// Composite is a structural design pattern that lets you compose
    /// objects into tree structures and then work with these
    /// structures as if they were individual objects
    /// </summary>
    class MyCompositeClient
    {
        public static void Run()
        {
            var composite = new MyContainer();
            var leaf = new MyLeaf();
            var leaf2 = new MyLeaf();
            composite.Add(leaf);
            composite.Add(leaf2);
            var composite2 = new MyContainer();
            composite.Add(composite2);
            var leaf3 = new MyLeaf();
            var leaf4 = new MyLeaf();
            composite2.Add(leaf3);
            composite2.Add(leaf4);
            composite2.Remove(leaf4);

            composite.Execute();

            var children = composite.GetChildren();
            Console.WriteLine("children: ");
            foreach (var child in children)
            {
                Console.WriteLine(child.GetType().Name);

            }
        }
    }
}
