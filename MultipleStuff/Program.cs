using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            List<double> list = new List<double>();
            SuperList superList = new SuperList();

            list.Add(2.0f);
            list.Add(1.0f);
            list.Add(17.0f);
            list.Add(4.0f);
            list.Add(2.1f);

            double min = 0;
            double max = 0;

            Console.WriteLine($"{min}, {max}");
            superList.GetMinMax1(ref list, out min, out max);
            Console.WriteLine($"{min}, {max}");
        }
    }
}
