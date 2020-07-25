using System;

namespace URI1074
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int N;
            N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                int X;
                X = int.Parse(Console.ReadLine());

                if (X > 0 && X % 2 == 0)
                {
                    Console.WriteLine("EVEN POSITIVE");
                }
                else if (X > 0 && X % 2 != 0) {
                    Console.WriteLine("ODD POSITIVE");
                }
                else if (X < 0 && X % 2 == 0)
                {
                    Console.WriteLine("EVEN NEGATIVE");
                }
                else if (X < 0 && X % 2 != 0)
                {
                    Console.WriteLine("ODD NEGATIVE");
                }
                else
                {
                    Console.WriteLine("NULL");
                }
            }
        }
    }
}
