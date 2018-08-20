using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatter.Code.Sample.Dotnet.Creation.Builder
{
    public class FerrariBuilder : ICarBuilder
    {
        public string Color { get; set; }
        public int NumDoors { get; set; }

        public Car GetResult()
        {
            return NumDoors == 2 ? new Car("Ferrari", "488 Spider", NumDoors, Color) : null;
        }
    }
}
