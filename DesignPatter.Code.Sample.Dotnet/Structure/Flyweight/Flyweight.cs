using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatter.Code.Sample.Dotnet.Structure.Flyweight
{
    public class Flyweight : IFlyweight
    {
        private string name;

        public Flyweight(string n)
        {
            this.name = n;
            State = "free";
        }

        public string State { get; set; }

        public string Operation()
        {
            State = "free";
            return $"Operated by {name}";
        }
    }
}
