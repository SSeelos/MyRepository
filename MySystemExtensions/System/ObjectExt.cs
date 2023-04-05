namespace MySystemExtensions
{
    public static class ObjectExt
    {
        public static string Display(this object subject)
        {
            return $"{subject.ToString()}{subject.GetType().Display()}";
        }
    }
}
