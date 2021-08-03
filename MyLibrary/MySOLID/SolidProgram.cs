namespace MyLibrary
{
    public class SolidProgram
    {
        public SolidProgram()
        {
            Run();
        }

        private void Run()
        {
            var square = new Square(2);
            var circle = new Circle(2);
            var hollowCircle = new HollowCircle(2, 1);
            var cube = new Cube(2);

            var calc = new AreaCalculator(square, circle, hollowCircle, cube);


            var outputter = new AreaCalculatorOutputter(calc);
            outputter.OutputVariant_1();
            outputter.OutputVariant_2();

        }
    }
}
