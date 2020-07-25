using System;
using System.Globalization;

namespace URI1154
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int idade = int.Parse(Console.ReadLine());
            int i = 0;
            int soma = 0;
            double media;

            while (idade > 0)
            {
                i += 1;
                soma += idade;
                idade = int.Parse(Console.ReadLine());
            }

            media = (double) soma / i;
            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
