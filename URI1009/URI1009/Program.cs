using System;
using System.Globalization;

namespace URI1009
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string vendedor;
            double salario, totVendas, totVendedor;

            vendedor = Console.ReadLine();
            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            totVendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            totVendedor = salario + totVendas * 15.0/100;

            Console.WriteLine("TOTAL = R$ " + totVendedor.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}