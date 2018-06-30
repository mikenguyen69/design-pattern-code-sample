using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatter.Code.Sample.Dotnet.Structure.Adapter
{
    public class Adapter : ITarget
    {
        private string name;
        private Adaptee adaptee;
        public Adapter(string name, Adaptee adaptee)
        {
            this.name = name;
            this.adaptee = adaptee;
        }

        public string Operation()
        {
            return $"{name} performed new operation. " + adaptee.SomeOperation();
        }
    }
}
