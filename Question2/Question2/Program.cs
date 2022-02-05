using System;
using System.Linq;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            string repeatedWord = "Bir saat sonra bütün görevlerimi JIRA üzerinden 'successfully' olarak çevireceğim";
            for (int i = 0; i < repeatedWord.Count() - 1; i++)
            {
                if (repeatedWord[i] == repeatedWord[i + 1])
                {
                    var result = string.Concat(repeatedWord[i], repeatedWord[i + 1]);
                    Console.WriteLine(result);

                }
            }
        }
    }
}
