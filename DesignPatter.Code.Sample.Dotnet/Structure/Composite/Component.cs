using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatter.Code.Sample.Dotnet.Structure.Composite
{
    public class Component : IComponent
    {
        private string name;
        public Component(string name)
        {
            this.name = name;
        }

        public string Operation()
        {
            return $"Operated by {name}.";
        }
    }
}
