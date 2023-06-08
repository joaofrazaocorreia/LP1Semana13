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
        public void GetMinMax2()
        {

        }
        public void GetMinMax3()
        {

        }
        public void GetMinMax4()
        {

        }
    }
}