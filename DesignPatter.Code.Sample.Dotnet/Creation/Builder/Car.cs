using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatter.Code.Sample.Dotnet.Creation.Builder
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int NumDoors { get; set; }
        public string Color { get; set; }

        public Car(string make, string model, int numDoor, string color)
        {
            Make = make;
            Model = model;
            NumDoors = numDoor;
            Color = color;
        }
    }
}
