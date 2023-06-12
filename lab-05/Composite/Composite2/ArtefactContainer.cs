using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite2
{
    public class ArtefactContainer : Artefact
    {
        private List<Artefact> Artefacts = new List<Artefact>();
        public ArtefactContainer(string name) : base(name, 0, 0)
        {
        }
        public void AddArtefact(Artefact artefact)
        {
            this.Artefacts.Add(artefact);
        }
        public void RemoveArtefact(Artefact artefact)
        {
            this.Artefacts.Remove(artefact);
        }
        public override int GetWeight()
        {
            return this.Artefacts.Aggregate(0, (sum, next) => sum += next.GetWeight());
        }
        public override int GetPowerBuf()
        {
            return this.Artefacts.Aggregate(0, (sum, next) => sum += next.GetPowerBuf());
        }
        public override int GetCount()
        {
            return this.Artefacts.Aggregate(0, (sum, next) => sum += next.GetCount());
        }
    
     }
}
