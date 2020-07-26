using System;

namespace URI1143
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i=1; i<=N; i++)
            {
                int quadrado = (int) Math.Pow(i, 2);
                int cubo = (int) Math.Pow(i, 3);

                Console.WriteLine(i + " " + quadrado + " " + cubo);
            }
        }
    }
}
