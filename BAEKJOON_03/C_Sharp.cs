using System;

namespace C_Sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input =Console.ReadLine();
            int rel = int.Parse(input);

            if ((rel % 4 == 0 && rel % 100 != 0) || rel % 400 == 0)
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
