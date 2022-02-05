using System;

namespace Question7
{
    class Program
    {
        // Fibonacci serisinin ilk 10 sayısının ekrana basımını yazınız
        // OUTPUT: 0 1 1 2 3 5 8 13 21 34
        static void Main(string[] args)
        {
            int a = 0, b = 1, c = 0;
            Console.Write("{0} {1}", a, b);
            for (int i = 2; i < 10; i++)
            {
                c = a + b;
                Console.Write(" {0}", c);
                a = b;
                b = c;
            }
        }
    }
}
