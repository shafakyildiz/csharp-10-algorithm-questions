using System;

namespace Question9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bir dizinin 2.büyük elemanını bulmak
            // INPUT => 1,4,2,-1,18,221,44,123,1,33,-10
            // OUTPUT => 123
            int[] array = { 1, 4, 2, -1, 18, 221, 44, 123, 1, 33, -10 };
            Array.Sort(array); // Sorting array  
            Array.Reverse(array); // Reverse Sorting array value  
            Console.WriteLine(array[1]);
        }
    }
}
