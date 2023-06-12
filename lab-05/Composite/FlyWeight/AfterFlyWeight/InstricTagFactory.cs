using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight.AfterFlyWeight
{
    public static class InstricTagFactory
    {
        private static Dictionary<string, InstrinsicTag> _cache = new Dictionary<string, InstrinsicTag>();

        public static void ShowDictCount()
        {
            foreach(var line in _cache)
            {
                Console.WriteLine($"Key: {line.Key}; Value: {line.Value};\n");
            }
            Console.WriteLine($"Cache count: {InstricTagFactory._cache.Count()}");
        }
        public static InstrinsicTag GetInstrinsicTag(string TagName, byte TagType, byte TagTypeClose)
        {
            string key = $"{TagName}-{TagType}-{TagTypeClose}";
            InstrinsicTag? tag = InstricTagFactory._cache.GetValueOrDefault(key);
            if (tag == null)
            { 
                tag = new InstrinsicTag(TagName, TagType, TagTypeClose);
                InstricTagFactory._cache[key] = tag;
            }
            return tag;
        }


    }
}
