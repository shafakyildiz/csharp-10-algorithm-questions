using System;

namespace Question10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number between 1 and 64: ");
            var num = Convert.ToInt32(Console.ReadLine());
            if (num > 64 || num < 1)
            {
                Console.WriteLine("You entered a number outside of the range.");
            }
            else
            {
                var lower = 1;
                var upper = 63;
                var error = 1;
                var step = 0;

                while ((upper - lower) > error)
                {
                    step++;
                    var middle = (lower + upper) * 0.5;
                    if (middle >= num)
                    {
                        upper = (int)middle;
                        Console.WriteLine("Lower is: {0}", lower);
                        Console.WriteLine("Upper is: {0}", upper);
                        Console.WriteLine("Step number : {0}", step);
                    }
                    else
                    {
                        lower = (int)middle;
                        Console.WriteLine("Lower is: {0}", lower);
                        Console.WriteLine("Upper is: {0}", upper);
                        Console.WriteLine("Step number : {0}", step);
                    }
                    Console.WriteLine();
                    Console.WriteLine("Our number is : {0}", upper);

                    // SAMPLE OUTPUT
                    //Please enter a number between 1 and 64:
                    //23
                    //Lower is: 1
                    //Upper is: 32
                    //Step number : 1

                    //Our number is : 32
                    //Lower is: 16
                    //Upper is: 32
                    //Step number : 2

                    //Our number is : 32
                    //Lower is: 16
                    //Upper is: 24
                    //Step number : 3

                    //Our number is : 24
                    //Lower is: 20
                    //Upper is: 24
                    //Step number : 4

                    //Our number is : 24
                    //Lower is: 22
                    //Upper is: 24
                    //Step number : 5

                    //Our number is : 24
                    //Lower is: 22
                    //Upper is: 23
                    //Step number : 6

                    //Our number is : 23
                }
            }
       
        }
    }
}
