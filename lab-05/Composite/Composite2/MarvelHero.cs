using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite2
{
    public class MarvelHero
    {
        private ArtefactContainer _artefacts = new ArtefactContainer("Hero's possession");
        public string Name { get; private set; }
        public List<MarvelHero> Friends { get; set; } = new List<MarvelHero>();
        public bool MainHero { get; set; }
        private int _power;
        public MarvelHero(string name, int power, bool mainHero = false)
        {
            this.Name = name;
            this._power = power;
            this.MainHero = mainHero;
        }
        public void AddFriend(MarvelHero friend)
        {
            Friends.Add(friend);
        }
        public void AddArtefact(Artefact artefact)
        {
            this._artefacts.AddArtefact(artefact);
            if (MainHero)
                Console.WriteLine($"{this.Name} get {artefact.Name}");
        }
        public void RemoveArtefact(Artefact artefact)
        {
            this._artefacts.RemoveArtefact(artefact);
            if (MainHero)
                Console.WriteLine($"{this.Name} lost {artefact.Name}");
        }
        public void Strike()
        {
            int totalPower = this._power + this._artefacts.GetPowerBuf();
            Console.WriteLine($"{this.Name} hits with power {totalPower}");
        }
        public void CalculateArtefactsWeight()
        {
            int totalArtefactsWeight = this._artefacts.GetWeight();
            Console.WriteLine($"Total artefacts weight: {totalArtefactsWeight}");
        }
        public void CountArtefacts()
        {
            int totalArtefactCount = this._artefacts.GetCount();
            Console.WriteLine($"{this.Name} has {totalArtefactCount} artefacts");
        }

    }
}

