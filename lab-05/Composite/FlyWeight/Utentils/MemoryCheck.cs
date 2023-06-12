using Composite.Classes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight.Classes
{
    static class MemoryCheck
    {
        public static void CheckMemory()
        {
            Process process = Process.GetCurrentProcess();
            string weight = process.WorkingSet.ToString();
            Console.WriteLine($"Physical memory usage: {double.Parse(weight) / 1000000.0:F2}MB\n");
        }
    }
}
