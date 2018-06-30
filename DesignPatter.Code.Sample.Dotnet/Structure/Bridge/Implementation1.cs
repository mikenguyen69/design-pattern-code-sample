using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatter.Code.Sample.Dotnet.Structure.Bridge
{
    public class Implementation1 : IBridge
    {
        public string OnImplementation()
        {
            return "Have implementation 1.";
        }
    }
}
