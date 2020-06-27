using System;
using System.Globalization;

namespace URI1015
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            string[] vet = Console.ReadLine().Split(' ');
            double x1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
            double y1 = double.Parse(vet[1], CultureInfo.InvariantCulture);

            vet = Console.ReadLine().Split(' ');
            double  x2 = double.Parse(vet[0], CultureInfo.InvariantCulture);
            double  y2 = double.Parse(vet[1], CultureInfo.InvariantCulture);

            double distancia = Math.Sqrt(Math.Pow(x2 - x1, 2.0) + Math.Pow(y2 - y1, 2.0));

            Console.WriteLine(distancia.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}