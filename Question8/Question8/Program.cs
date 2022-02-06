using System;
public class PrimeNumberExample
{
    public static void Main(string[] args)
    {
        int sumOfNotPrimes = 0;
        for (int n = 2; n < 100; n++)
        {
            int i, m = 0, flag = 0;
            m = n / 2;
            for (i = 2; i <= m; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine("{0} is not Prime.", n);
                    flag = 1;
                    sumOfNotPrimes += n;
                    break;
                }
            }
            Console.WriteLine("Sum of not prime numbers: {0}", sumOfNotPrimes);

            if (flag == 0)
                Console.WriteLine("{0} is Prime.", n);
        }
    
    }
}