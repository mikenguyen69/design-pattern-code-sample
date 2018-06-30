using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatter.Code.Sample.Dotnet.Structure.Flyweight
{
    class FlyweightFactory
    {
        private List<Flyweight> flyweights;

        public FlyweightFactory(List<Flyweight> list)
        {
            this.flyweights = list;
        }

        public Flyweight GetFlyweight()
        {
            var instance = flyweights.FirstOrDefault(x => x.State == "free");
            if (instance != null)
            {
                instance.State = "used";
            }
            else
            {
                instance = new Flyweight("FNew");
                instance.State = "used";
                flyweights.Add(instance);
            }

            return instance;
        }
    }
}
