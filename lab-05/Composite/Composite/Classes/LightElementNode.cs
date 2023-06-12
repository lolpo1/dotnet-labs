using Composite.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Composite.Classes
{
    public class LightElementNode : LightNode, IClone
    {
        public string TagName { set; get; }
        public byte TagType { set; get; } //block = 1;line = 0;
        public byte TagCloseType { set; get; } //close = 1; no close = 0;
        public Style? Style { set; get; }
        public List<LightNode> Nodes { set; get; } = new List<LightNode>();

        public LightElementNode(string TagName, byte TagType = 1, byte TagCloseType = 1)
        { 
            this.TagName = TagName;
            this.TagType = TagType;
            this.TagCloseType = TagCloseType;
        }

        public LightElementNode(LightElementNode origin)
        {
            this.TagName = origin.TagName;
            this.TagType = origin.TagType;
            this.TagCloseType = origin.TagCloseType;
            if (Style != null)
            {
                this.Style = (Style)origin.Style.Clone();
            }
            if (origin.Nodes != null)
            {
                foreach (var node in origin.Nodes)
                {
                    if (node is LightTextNode)
                        this.Nodes.Add((LightTextNode)node.Clone());
                    else
                        this.Nodes.Add((LightElementNode)node.Clone());

                }
            }
        }

        public override string GetOuterHtml()
        {
            StringBuilder tag = new StringBuilder();
            if (this.TagCloseType == 1)
            {
                tag.Append($"<{this.TagName}{this.Style?.ToString()}>\n");
                if (this.Nodes != null)
                {
                    foreach (var node in Nodes)
                    {
                        if (node is LightTextNode)
                            tag.Append(node.GetContent());
                        else
                            tag.Append(node.GetOuterHtml());
                    }
                }
                tag.Append($"</{this.TagName}>\n");
            }
            if (this.TagCloseType == 0)
            {
                tag.Append($"<{this.TagName} {this.Style?.ToString()}/>\n");
            }
            return tag.ToString();
        }
        public string GetInnerHtml()
        {
            StringBuilder tag = new StringBuilder();
            if (this.TagCloseType == 1)
            {
                if (this.Nodes != null)
                {
                    foreach (var node in Nodes)
                    {
                        if (node is LightTextNode)
                            tag.Append(node.GetContent());
                        else
                            tag.Append(node.GetOuterHtml());
                    }
                }
            }
            if (this.TagCloseType == 0)
            {
                tag.Append($"");
            }
            return tag.ToString();
        }
     
        public void AppendNode(LightNode node)
        { 
            this.Nodes.Add(node);
        }
        public void RemoveNode(LightNode node) 
        { 
            this.Nodes.Remove(node);
        }
        public void ReplaceNode(LightNode OldNode, LightNode NewNode)
        {
            if (this.Nodes != null)
            {
                for (int i = 0; i < this.Nodes.Count; i++)
                {
                    if (this.Nodes[i] == OldNode)
                    {
                        this.Nodes[i] = NewNode;
                        return;
                    }
                    Console.WriteLine("No Node.");
                }
            }
        }
        public void InsertBefore(LightNode NodeBefore, LightNode NewNode)
        {
            if (this.Nodes != null) { 
                var index = this.Nodes.FindIndex(x => x == NodeBefore);
                Console.WriteLine(index);
                this.Nodes.Insert(index, NewNode);
            }
        }

        public override IClone Clone()
        {
            return new LightElementNode(this);
        }
    }
}
