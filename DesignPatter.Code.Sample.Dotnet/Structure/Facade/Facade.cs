using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatter.Code.Sample.Dotnet.Structure.Facade
{
    public class Facade
    {
        private SubSystemA A;
        private SubsystemB B;
        private SubSystemC C;

        public Facade(SubSystemA a, SubsystemB b, SubSystemC c)
        {
            A = a;
            B = b;
            C = c;
        }

        public object Operation1()
        {
            return A.Operation1();
        }

        public object Operation2()
        {
            return B.Operation2();
        }

        public object Operation3()
        {
            return C.Operation3();
        }
    }
}
