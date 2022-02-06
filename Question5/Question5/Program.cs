using System;
using System.Linq;

namespace Question5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Find duplicate words in a string...
            // asla = 2
            // hiç = 2
            // bir = 2
            // zaman = 2
            var myStr = "Asla hiç bir zaman asla deme ki ; hiç bir zaman nolacağı belli olmaz";
            myStr = myStr.ToLower();
            var splitted = myStr.Split(' ');
            int count;
            for (int i = 0; i < splitted.Length - 1; i++)
            {
                count = 1;
                for (int j = i+1; j < splitted.Length; j++)
                {
                    if (splitted[i] == splitted[j])
                    {
                        count++;
                        splitted[j] = "0";
                    }
                }
                if (count > 1 && splitted[i] != "0")
                {
                    Console.WriteLine("{0} = {1}", splitted[i], count);
                }
            }
         
        }
    }
}