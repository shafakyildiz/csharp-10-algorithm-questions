using System;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            var tempSymbol = "K";
            var tempDeg = 273;
            Console.WriteLine("Your temp is: {0} C and {1} K", tempDeg - 273, (tempDeg - 273.15) * 1.8 + 32 );
        }

    }
}
