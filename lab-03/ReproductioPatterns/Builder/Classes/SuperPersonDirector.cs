using Builder.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Classes
{
    public class SuperPersonDirector
    {
        private ISuperPersonBuilder _builder;

        public SuperPersonDirector(ISuperPersonBuilder builder)
        { 
            this._builder = builder;
        }

        public SuperPersonDirector SetBuilder(ISuperPersonBuilder builder)
        {
            this._builder = builder;
            return this;
        }
        public Person GetSimpleRobber()
        {
            return this._builder
                .SetName("John")
                .SetState("Thief")
                .SetMainWeapon("scrap")
                .GetSuperPerson();
        }
        public Person GetSuperman()
        {
            return this._builder
                .SetName("Superman")
                .SetState("Hero")
                .SetMainWeapon("NotEarthPowerful")
                .SetFeatures(new[] { "lazer from eyes", "armour-piercing" })
                .SetVulnerables(new[] { "cryptonit" })
                .GetSuperPerson();
        }
    }
}
