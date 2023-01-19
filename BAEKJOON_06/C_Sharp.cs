using System;

namespace C_Sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input =Console.ReadLine().Split(' ');
            string wTime = Console.ReadLine();
            int[] rel = Array.ConvertAll(input, int.Parse);
            int wTimerel = int.Parse(wTime);

            int total = wTimerel + rel[1];
            if (total >= 60)
            {
                rel[0] += total / 60;
                rel[1] = total % 60;
                if (rel[0] >= 24)
                {
                    rel[0] -= 24;
                }

            }
            else if (total < 60)
            {
                rel[1] = total;
            }
            Console.WriteLine(rel[0]+" " + rel[1]);


        }
    }
}
