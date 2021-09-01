using System;

namespace MyLibrary.MyDesignPrinciples.Composite
{
    class MyCompositeClient
    {
        public static void Run()
        {
            var composite = new MyComposite();
            var leaf = new MyLeaf();
            var leaf2 = new MyLeaf();
            composite.Add(leaf);
            composite.Add(leaf2);
            var composite2 = new MyComposite();
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
