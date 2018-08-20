using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatter.Code.Sample.Dotnet.Creation.Builder
{
    public class SportCarBuildDirector
    {
        private ICarBuilder _builder;

        public SportCarBuildDirector(ICarBuilder builder)
        {
            _builder = builder;
        }

        public void Construct()
        {
            _builder.Color = "Red";
            _builder.NumDoors = 2;
        }
    }
}
