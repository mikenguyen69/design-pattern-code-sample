using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatter.Code.Sample.Dotnet.Creation.FactoryMethod
{
    class ProductA : IProduct
    {
        public string Functionality()
        {
            return "Product A Functionality";
        }
    }

    class ProductB : IProduct
    {
        public string Functionality()
        {
            return "Product B Functionality";
        }
    }
}
