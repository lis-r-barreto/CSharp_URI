using System;

namespace URI1072
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int N, qtdIn, qtdOut;

            N = int.Parse(Console.ReadLine());

            qtdIn = 0;
            qtdOut = 0;

            for (int i = 1; i <= N; i++)
            {
                int X;
                X = int.Parse(Console.ReadLine());

                if (X >= 10 && X <=20)
                {
                    qtdIn += 1;
                }

                else
                {
                    qtdOut += 1;
                }
            }

            Console.WriteLine(qtdIn + " in");
            Console.WriteLine(qtdOut + " out");
        }
    }
}
