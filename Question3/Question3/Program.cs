using System;
using System.Linq;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list1 = { 13, 2, 10, 4, 0, 3, 12, 44, 112 };
            double minimum = list1.Min();
            int minIndex = Array.IndexOf(list1, list1.Min()) + 1;
            Console.WriteLine("Dizinin en küçük elemanı {0} dır. Bulunduğu yer {1} Sıradır.", minimum, minIndex);
        }
    }
}
