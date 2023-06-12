using Builder.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Classes.Builders
{
    public class HeroBuilder : ISuperPersonBuilder
    {
        private Person _Hero = new Person();

        public HeroBuilder() {
            this._reset();
         }

        public Person GetSuperPerson()
        {
            Person _hero = this._Hero;
            this._reset();
            return _hero;
        }

        public ISuperPersonBuilder SetBody(string body)
        {
            this._Hero.Body = body;
            return this;
        }

        public ISuperPersonBuilder SetClothesStyle(string clothesstyle)
        {
            this._Hero.ClothesStyle = clothesstyle;
            return this;

        }

        public ISuperPersonBuilder SetEyesColor(string eyecolor)
        {
            this._Hero.EyesColor = eyecolor;
            return this;

        }

        public ISuperPersonBuilder SetFeatures(string[] features)
        {
            this._Hero.Features = features;
            return this;

        }

        public ISuperPersonBuilder SetHairColor(string haircolor)
        {
            this._Hero.HairColor = haircolor;
            return this;

        }

        public ISuperPersonBuilder SetHairStyle(string hairstyle)
        {
            this._Hero.HairStyle = hairstyle;
            return this;

        }

        public ISuperPersonBuilder SetHeight(string height)
        {
            this._Hero.Height = height; 
            return this;

        }

        public ISuperPersonBuilder SetMainWeapon(string weapon)
        {
            this._Hero.MainWeapon = weapon;
            return this;

        }

        public ISuperPersonBuilder SetName(string name)
        {
            this._Hero.Name = name;
            return this;
        }

        public ISuperPersonBuilder SetState(string state)
        {
            this._Hero.State = state;
            return this;
        }

        public ISuperPersonBuilder SetVulnerables(string[] vulnerable)
        {

            this._Hero.Vulnerable = vulnerable;
            return this;
        }

        private void _reset()
        { 
            this._Hero = new Person();
        }
    }
}
