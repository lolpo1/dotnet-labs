using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite2
{
    public class CompositeArtefact : Artefact
    {
        private List<Artefact> Artefacts = new List<Artefact>();
        public CompositeArtefact(string name, int weight, int powerBuf) : base(name, weight, powerBuf)
        {
        }
        public override int GetPowerBuf()
        {
            return this.Artefacts.Aggregate(this._powerBuf, (sum, next) => sum += next.GetPowerBuf());
        }
        public override int GetWeight()
        {
            return this.Artefacts.Aggregate(this._weight, (sum, next) => sum += next.GetWeight());
        }
        public void AddArtefact(Artefact artefact)
        {
            this.Artefacts.Add(artefact);
        }
        public void RemoveArtefact(Artefact artefact)
        {
            this.Artefacts.Remove(artefact);
        }
        public override int GetCount()
        {
            int sum = 1;
            foreach (var artefact in Artefacts)
            {
                sum += artefact.GetCount();
            }
            return sum;
        }
    }
}
