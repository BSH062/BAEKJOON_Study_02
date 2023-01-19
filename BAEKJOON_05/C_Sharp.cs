using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int[] rel = Array.ConvertAll(input, int.Parse);

            if (rel[1]>=45)
            {
                rel[1] -= 45;
            }
            else if (rel[1]<45)
            {
                if (rel[0]==0)
                {
                    rel[0] += 23;
                    rel[1] = rel[1] + (60 - 45);
                }
                else
                {
                    rel[0]--;
                    rel[1] = rel[1] + (60 - 45);
                }
            }
            Console.WriteLine(rel[0] +" "+ rel[1] );
        }
    }
}
