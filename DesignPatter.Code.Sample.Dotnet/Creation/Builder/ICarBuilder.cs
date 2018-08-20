using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatter.Code.Sample.Dotnet.Creation.Builder
{
    public interface ICarBuilder
    {
        string Color { get; set; }
        int NumDoors { get; set; }

        Car GetResult();
    }
}
