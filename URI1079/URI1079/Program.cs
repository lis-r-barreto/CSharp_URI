using System;
using System.Globalization;

namespace URI1079
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int N;
            N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');

                double nota1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
                double nota2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
                double nota3 = double.Parse(vet[2], CultureInfo.InvariantCulture);

                double media = (2.0 * nota1 + 3.0 * nota2 + 5.0 * nota3) / 10.0;

                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
