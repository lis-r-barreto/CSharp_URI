using System;

namespace URI1099
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
                int x = int.Parse(s[0]);
                int y = int.Parse(s[1]);

                if (x > y)
                {
                    int aux = x;
                    x = y;
                    y = aux;
                }

                int soma = 0;
                for (int j= x + 1; j < y; j++)
                {
                    if (j % 2 != 0)
                    {
                        soma += j;
                    }
                }

                Console.WriteLine(soma);
            }

        }
    }
}
