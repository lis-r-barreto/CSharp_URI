using System;

namespace URI1159
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            while (x != 0)
            {
                if (x % 2 != 0)
                {
                    x += 1;
                }

                int soma = x + x + 2 + x + 4 + x + 6 + x + 8;
                Console.WriteLine(soma);

                x = int.Parse(Console.ReadLine());
            }
        }
    }
}
