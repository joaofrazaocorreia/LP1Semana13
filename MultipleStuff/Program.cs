﻿using System;
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

            SuperList list = new SuperList();

            list.Add(2.0f);
            list.Add(1.0f);
            list.Add(17.0f);
            list.Add(4.0f);
            list.Add(2.1f);

            for (int i = 0; i < 4; i++)
            {
                double min = 0;
                double max = 0;

                Console.WriteLine($"{min}, {max}");
                switch(i)
                {
                    case 0:
                        list.GetMinMax1(out min, out max);
                        break;

                    case 1:
                        MinMaxStruct minmaxStruct = list.GetMinMax2();
                        min = minmaxStruct.Min;
                        max = minmaxStruct.Max;
                        break;

                    case 2:
                        break;
                        
                    case 3:
                        break;
                }
                Console.WriteLine($"{min}, {max}");
                Console.WriteLine("-------------");
            }
        }
    }
}
