using System;

namespace URI1075
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int N;
            N = int.Parse(Console.ReadLine());

            for (int i = 1; i < 10000; i++)
            {
                if (i % N == 2)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
