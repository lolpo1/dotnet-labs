using Builder.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Classes.Builders
{
    public class EnemyBuilder : ISuperPersonBuilder
    {

        private Person _Enemy = new Person();

        public EnemyBuilder()
        {
            this._reset();
            this._Enemy.ClothesStyle = "mask";
            this._Enemy.Vulnerable = new[] {"all people weaknesses"};
        }

        public Person GetSuperPerson()
        {
            Person _enemy = this._Enemy;
            this._reset();
            return _enemy;
        }

        public ISuperPersonBuilder SetBody(string body)
        {
            this._Enemy.Body = body;
            return this;
        }

        public ISuperPersonBuilder SetClothesStyle(string clothesstyle)
        {
            this._Enemy.ClothesStyle = clothesstyle;
            return this;

        }

        public ISuperPersonBuilder SetEyesColor(string eyecolor)
        {
            this._Enemy.EyesColor = eyecolor;
            return this;

        }

        public ISuperPersonBuilder SetFeatures(string[] features)
        {
            this._Enemy.Features = features;
            return this;

        }

        public ISuperPersonBuilder SetHairColor(string haircolor)
        {
            this._Enemy.HairColor = haircolor;
            return this;

        }

        public ISuperPersonBuilder SetHairStyle(string hairstyle)
        {
            this._Enemy.HairStyle = hairstyle;
            return this;

        }

        public ISuperPersonBuilder SetHeight(string height)
        {
            this._Enemy.Height = height;
            return this;

        }

        public ISuperPersonBuilder SetMainWeapon(string weapon)
        {
            this._Enemy.MainWeapon = weapon;
            return this;

        }

        public ISuperPersonBuilder SetName(string name)
        {
            this._Enemy.Name = name;
            return this;
        }

        public ISuperPersonBuilder SetState(string state)
        {
            this._Enemy.State = state;
            return this;
        }

        public ISuperPersonBuilder SetVulnerables(string[] vulnerable)
        {
            this._Enemy.Vulnerable = vulnerable;
            return this;
        }

        private void _reset()
        {
            this._Enemy = new Person();
        }
    }
}
