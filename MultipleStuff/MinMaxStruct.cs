using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleStuff
{
    public class MinMaxStruct
    {
        public double Min { get; }
        public double Max { get; }
        public MinMaxStruct(double min, double max)
        {
            Min = min;
            Max = max;
        }
    }
}