using System;

namespace URI1071
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int x, y, min, max;

            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            if (x < y)
            {
                min = x;
                max = y;
            }
            else
            {
                min = y;
                max = x;
            }
            int soma = 0;
            for (int i = min + 1; i < max; i++)
            {
                if (i % 2 != 0)
                {
                    soma += i;
                }

            }

            Console.WriteLine(soma);
        }
    }
}
