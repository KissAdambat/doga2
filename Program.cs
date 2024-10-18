using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doga2
{
    internal class Program
    {

        static void szamlalas()
        {
            int positiveSum = 0;
            int negativeSum = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Kérem adjon meg egy egész számot ({i + 1}/10): ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int number))
                {
                    if (number > 0)
                    {
                        positiveSum += number;
                    }
                    else if (number < 0)
                    {
                        negativeSum += number;
                    }
                    
                }
                else
                {
                    Console.WriteLine("Kérem, egy érvényes egész számot adjon meg.");
                    i--;
                }
            }

            Console.WriteLine($"A pozitív számok összege: {positiveSum}");
            Console.WriteLine($"A negatív számok összege: {negativeSum}");
        }

        static void Main(string[] args)
        {
            szamlalas();
        }
    }
}
