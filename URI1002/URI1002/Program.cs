using System;
using System.Globalization;

namespace URI1002
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double raio, pi, area;

            pi = 3.14159;


            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            area = pi * raio * raio;


            Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}