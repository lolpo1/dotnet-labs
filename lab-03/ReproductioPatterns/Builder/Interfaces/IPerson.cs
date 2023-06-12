using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public interface IPerson
    {
        public string State { get; set; }
        public string Name { get; set; }
        public string? Height { get; set; }
        public string? Body { get; set; }
        public string? HairStyle { get; set; }
        public string? HairColor { get; set; }
        public string? EyesColor { get; set; }
        public string? ClothesStyle { get; set; }
        public string? MainWeapon { get; set; }
        public string[]? Features { get; set; }

        public string[]? Vulnerable { get; set; }


        public void ShowPerson();

    }
}
