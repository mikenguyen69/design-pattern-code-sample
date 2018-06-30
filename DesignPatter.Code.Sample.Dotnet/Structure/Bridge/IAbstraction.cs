using System.Collections.Generic;
using System.Linq;

namespace DesignPatter.Code.Sample.Dotnet.Structure.Bridge
{
    public abstract class IAbstraction
    {
        public List<IBridge> Bridge = new List<IBridge>();

        public virtual string Operation()
        {
            return string.Join(" ", Bridge.Select(x => x.OnImplementation()));
        }
    }
}
