using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleStuff
{
    public class SuperList : List<double>
    {
        double min;
        double max;

        public void GetMinMax1
        (out double min, out double max)
        {
            List<double> sortList = this;
            sortList.Sort();
            min = sortList[0];
            max = sortList[this.Count-1];
        }
        public MinMaxStruct GetMinMax2()
        {
            GetMinMax1(out min, out max);

            return new MinMaxStruct(min, max);
        }     
        public Tuple<double, double> GetMinMax3()
        {
            GetMinMax1(out min, out max);

            return Tuple.Create(min, max);
        }
        public void GetMinMax4()
        {

        }
    }

    public struct MinMaxStruct
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