using System;
using System.Collections.Generic;
using System.Linq;

namespace Question4
{
    class Program
    {
        static void Main(string[] args)
        {
            // INPUT => 123
            // OUTPUT => 1,2,3 – 12,13,21,23,31,32 – 123

            var num = Convert.ToString(123);
            Console.WriteLine(num);
            var i = 0;
            num = string.Concat(num, num);
            while (i < num.Length - 1)
            {
                Console.WriteLine("{0}{1}", num[i], num[i+1]);
                if (i < num.Length - 2)
                {
                    Console.WriteLine("{0}{1}", num[i], num[i + 2]);
                }
                i++;
            }
        }
    }
}
