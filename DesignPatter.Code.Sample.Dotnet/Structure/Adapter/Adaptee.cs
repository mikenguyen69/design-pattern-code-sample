using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatter.Code.Sample.Dotnet.Structure.Adapter
{
    public class Adaptee
    {
        private string name;

        public Adaptee(string name)
        {
            this.name = name;
        }
        public string SomeOperation()
        {
            return $"{name} performed some existing operation. ";
        }
    }
}
