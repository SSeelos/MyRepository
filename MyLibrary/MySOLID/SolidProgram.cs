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
            var square = new Square(1);
            var circle = new Circle(2);

            var calc = new AreaCalculator(square, circle);


            var outputter = new AreaCalculatorOutputter(calc);
            outputter.OutputVariant_1();
            outputter.OutputVariant_2();

        }
    }
}
