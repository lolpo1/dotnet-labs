using Composite.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Classes
{
    public class Style : IClone
    {
        public Dictionary<string, string> Styles { set; get; } = new Dictionary<string, string>();
        public Style() { }

        public Style(Style origin)
        {
           this.Styles = new Dictionary<string, string>(origin.Styles);
        }

        public void AddStyle(string name, string value) 
        {  
            Styles.Add(name, value);
        }

        public void RemoveStyle(string name)
        {
            Styles.Remove(name);
        }

        public override string ToString()
        { 
            StringBuilder str = new StringBuilder();
            str.Append(" style=\"");
            foreach (var style in Styles) 
            {
                str.Append($"{style.Key}:{style.Value};");
            }
            str.Append("\"");
            return str.ToString();
        }

        public IClone Clone()
        {
            return new Style(this);
        }
    }
}
