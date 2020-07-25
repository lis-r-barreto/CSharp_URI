using System;

namespace URI1073
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int N;
            N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                if (i % 2 == 0) {
                    int quadrado = (int)Math.Pow(i, 2);
                    Console.WriteLine(i + "^2 = " + quadrado);
                }
            }
        }
    }
}
