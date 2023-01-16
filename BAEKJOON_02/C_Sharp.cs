using System;

namespace C_Sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int rel = int.Parse(input);

            if (rel >= 90)
            {
                Console.WriteLine("A");
            }
            else if (89 >= rel || rel>=80)
            {
                Console.WriteLine("B");
            }
            else if (79 >= rel || rel >= 70)
            {
                Console.WriteLine("C");
            }
            else if (69 >= rel || rel >= 60)
            {
                Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("F");
            }


        }
    }
}
