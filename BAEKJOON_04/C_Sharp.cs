using System;
using System.Runtime.ConstrainedExecution;

namespace C_Sharp
{
    internal class Program
    {
        int[] rel;
        static void Main(string[] args)
        {
            string x = Console.ReadLine();  
            string y = Console.ReadLine();  
            int xl = int.Parse(x);  
            int yl = int.Parse(y);

            if (xl > 0 && yl > 0)
            {
                Console.WriteLine("1");
            }
            else if (xl < 0 && yl > 0)
            {
                Console.WriteLine("2");
            }
            else if (xl < 0 && yl< 0)
            {
                Console.WriteLine("3");
            }
            else
            {
                Console.WriteLine("4");
            }


        }
    }
}
