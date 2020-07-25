using System;
using System.Globalization;

namespace URI1116
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int N;
            N = int.Parse(Console.ReadLine());

            for (int i=0; i<N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                int x = int.Parse(s[0], CultureInfo.InvariantCulture);
                int y = int.Parse(s[1], CultureInfo.InvariantCulture);

                if (y > 0 || y < 0)
                {
                    double divisao = (double) x / (double) y;
                    Console.WriteLine(divisao.ToString("F1", CultureInfo.InvariantCulture));
                }
                else
                {
                    Console.WriteLine("divisao impossivel");
                }
            }
        }
    }
}
