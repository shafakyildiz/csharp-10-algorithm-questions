using System;

namespace Question6
{
    class Program
    {
        static void Main(string[] args)
        {
            // 0 - 100000 arasındaki tam kare sayıları ekrana yazdırınız.
            // OUTPUT => 2,3,4,5 …. (x’2 < 10000) olana kadar devam eder
            var x = 2;
            while (x*x < 10000)
            {
                Console.WriteLine(x);
                x++;
            }
        }
    }
}
