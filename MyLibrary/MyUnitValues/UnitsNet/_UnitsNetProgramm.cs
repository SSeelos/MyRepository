using System;
using System.Collections.Generic;
using System.Text;
using UnitsNet;

namespace MyLibrary_DotNETstd_2_1
{
    public class UnitsNetProgram : IProgram
    {
        public void Run()
        {
            var qu = new QuantityValue();
            qu = 1000;
            Length lengthA = Length.From(qu, UnitsNet.Units.LengthUnit.Millimeter);
            Length lengthB = Length.From(100, UnitsNet.Units.LengthUnit.Centimeter);

            Length result = lengthB + lengthA;
            var conv = result.Meters;
        }
    }
}
