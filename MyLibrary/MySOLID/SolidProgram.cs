﻿namespace MyLibrary
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

            var areaCalc = new AreaCalculator(square, circle, hollowCircle, cube);


            var areaOutputter = new CalculatorOutputter(areaCalc);
            areaOutputter.OutputVariant_1();
            areaOutputter.OutputVariant_2();


            var volumeCalc = new VolumeCalculator(cube);


            var volOutputter = new CalculatorOutputter(volumeCalc);
            volOutputter.OutputVariant_1();
            volOutputter.OutputVariant_2();

        }
    }
}
