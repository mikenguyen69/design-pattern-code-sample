using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatter.Code.Sample.Dotnet.Creation.Singleton
{
    public sealed class Singleton
    {
        private static readonly Singleton instance = new Singleton();

        private Singleton()
        {
            
        }

        public string Message = "";

        public static Singleton Instance
        {
            get
            {
                return instance;
            }
        }     
    }
}
