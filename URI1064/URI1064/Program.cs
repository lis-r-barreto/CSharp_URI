using System;
using System.Globalization;

namespace URI1064
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, n4, n5, n6, nMedia, media;
            int qtdPositivos;
            n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n4 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n5 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n6 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            qtdPositivos = 0;
            nMedia = 0.0;
            
            if (n1 >= 0)
            {
                qtdPositivos += 1;
                nMedia += n1;
            }
            else
            {
                qtdPositivos += 0;
                nMedia += 0.0;
            }

            if (n2 >= 0)
            {
                qtdPositivos += 1;
                nMedia += n2;
            }
            else
            {
                qtdPositivos += 0;
                nMedia += 0.0;
            }

            if (n3 >= 0)
            {
                qtdPositivos += 1;
                nMedia += n3;
            }
            else
            {
                qtdPositivos += 0;
                nMedia += 0.0;
            }

            if (n4 >= 0)
            {
                qtdPositivos += 1;
                nMedia += n4;
            }
            else
            {
                qtdPositivos += 0;
                nMedia += 0.0;
            }

            if (n5 >= 0)
            {
                qtdPositivos += 1;
                nMedia += n5;
            }
            else
            {
                qtdPositivos += 0;
                nMedia += 0.0;
            }

            if (n6 >= 0)
            {
                qtdPositivos += 1;
                nMedia += n6;
            }
            else
            {
                qtdPositivos += 0;
                nMedia += 0.0;
            }

            media = nMedia / qtdPositivos;
            Console.WriteLine(qtdPositivos + " valores positivos");
            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
