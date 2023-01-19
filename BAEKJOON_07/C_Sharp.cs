using System;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int[] rel = Array.ConvertAll(input, int.Parse);
            int con=0;
            int total;

            if (rel[0] == rel[1] && rel[1] == rel[2])
            {
                total = 10000 + (rel[0] * 1000);
            }
            else if (rel[0] == rel[1] || rel[1] == rel[2] || rel[0] == rel[2])
            {
                if (rel[0] == rel[1] || rel[0] == rel[2])
                {
                    con = rel[0];
                }
                else
                {
                    con = rel[1];
                }
                total = 1000 + (con * 100);
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    if (rel[i] > con)
                    {
                        con = rel[i];
                    }
                }
                total = con * 100;
            }
            Console.WriteLine(total); 
        }
    }
}
