using System;
using System.Globalization;

namespace URI1060
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, n4, n5, n6;
            int qtdPositivos;
            n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n4 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n5 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n6 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            qtdPositivos = 0;

            if (n1 >= 0)
            {
                qtdPositivos += 1;
            }
            else
            {
                qtdPositivos += 0;
            }

            if (n2 >= 0)
            {
                qtdPositivos += 1;
            }
            else
            {
                qtdPositivos += 0;
            }
            
            if (n3 >= 0)
            {
                qtdPositivos += 1;
            }
            else
            {
                qtdPositivos += 0;
            }

            if (n4 >= 0)
            {
                qtdPositivos += 1;
            }
            else
            {
                qtdPositivos += 0;
            }

            if (n5 >= 0)
            {
                qtdPositivos += 1;
            }
            else
            {
                qtdPositivos += 0;
            }

            if (n6 >= 0)
            {
                qtdPositivos += 1;
            }
            else
            {
                qtdPositivos += 0;
            }

            Console.WriteLine(qtdPositivos + " valores positivos");
        }
    }
}
