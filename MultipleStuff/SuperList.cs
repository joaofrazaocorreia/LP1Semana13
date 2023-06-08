using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleStuff
{
    public class SuperList : List<double>
    {
        public void GetMinMax1
        (ref List<double> list, out double min, out double max)
        {
            List<double> sortList = list;
            sortList.Sort();
            min = sortList[0];
            max = sortList[list.Count-1];
        }
        public static MinMaxStruct GetMinMax2(List<double> list)
        {
            List<double> sortList = list;
            sortList.Sort();
            double min = sortList[0];
            double max = sortList[list.Count-1];

            return new MinMaxStruct(min, max);
        }     
        public void GetMinMax3()
        {

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