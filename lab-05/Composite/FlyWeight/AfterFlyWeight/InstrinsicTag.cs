using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight.AfterFlyWeight
{
    public class InstrinsicTag
    {
        public string TagName { set; get; }
        public byte TagType { set; get; } //block = 1;line = 0;
        public byte TagCloseType { set; get; } //close = 1; no close = 0;

        public InstrinsicTag(string TagName, byte TagType, byte TagTypeClose) 
        { 
            this.TagName = TagName;
            this.TagType = TagType;
            this.TagCloseType = TagTypeClose;
        }
    }
}
