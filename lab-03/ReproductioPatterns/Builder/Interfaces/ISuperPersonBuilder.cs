using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.interfaces
{
    public interface ISuperPersonBuilder
    {
        public Person GetSuperPerson();
        public ISuperPersonBuilder SetHeight(string height);
        public ISuperPersonBuilder SetBody(string body);
        public ISuperPersonBuilder SetName(string name);
        public ISuperPersonBuilder SetState(string state);
        public ISuperPersonBuilder SetHairStyle(string hairstyle);
        public ISuperPersonBuilder SetHairColor(string haircolor);
        public ISuperPersonBuilder SetEyesColor(string eyecolor);
        public ISuperPersonBuilder SetClothesStyle(string clothesstyle);
        public ISuperPersonBuilder SetMainWeapon(string weapon);
        public ISuperPersonBuilder SetFeatures(string[] features );
        public ISuperPersonBuilder SetVulnerables(string[] vulnerable );
    }
}
