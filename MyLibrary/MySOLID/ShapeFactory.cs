namespace MyLibrary
{
    //Factory can be used to create new instances in a decoupled way
    //(because of DIP)
    public static class ShapeFactory        //(DIP)
    {
        public static ILine CreateLine(double x)
        {
            return new Line(x);
        }
        public static ISquare CreateSquare()
        {
            return new Square();
        }
        public static IShape2D CreateCircle()
        {
            return new Circle();
        }
        public static IShape2D CreateHollowCircle(double radius, double innerRadius)
        {
            return new HollowCircle(radius,innerRadius);
        }
        //public static IShape CreateCube()
        //{
        //    return new Cube();
        //}
    }
}
