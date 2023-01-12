using System;

namespace C_Sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int[] INT = Array.ConvertAll(input, int.Parse);

            if (INT[0] > INT[1])
            {
                Console.WriteLine(">");
            }
            else if(INT[0] < INT[1])
            {
                Console.WriteLine("<");
            }
            else
            {
                Console.WriteLine("==");
            }
        }
    }
}
