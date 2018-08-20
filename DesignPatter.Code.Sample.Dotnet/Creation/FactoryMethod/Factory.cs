    using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatter.Code.Sample.Dotnet.Creation.FactoryMethod
{
    static class Factory
    {
        public static IProduct GetProduct(string type)
        {
            switch(type)
            {
                case "A": return new ProductA();
                case "B": return new ProductB();
                default: return null;
            }
        }
    }
}
