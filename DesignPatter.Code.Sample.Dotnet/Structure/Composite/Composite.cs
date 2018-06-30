using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatter.Code.Sample.Dotnet.Structure.Composite
{
    public class Composite : IComponent
    {
        private List<IComponent> list;
        private string name;

        public Composite(string name, List<IComponent> list)
        {
            this.name = name;
            this.list = list;
        }

        public string Operation()
        {
            string opt = $"Operated by {name}. ";
            opt += string.Join(" ", list.Select(x => x.Operation()));

            return opt;
        }
    }
}
