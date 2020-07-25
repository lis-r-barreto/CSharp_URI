using System;
using System.Globalization;

namespace URI1118
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int novoCalc = 1;

            while (novoCalc == 1)
            {
                double nota1 = double.Parse(Console.ReadLine());
                while (nota1 < 0.0 || nota1 > 10.0)
                {
                    Console.WriteLine("nota invalida");
                    nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }

                double nota2 = double.Parse(Console.ReadLine());
                while (nota2 < 0.0 || nota2 > 10.0)
                {
                    Console.WriteLine("nota invalida");
                    nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }

                double media = (nota1 + nota2) / 2.0;
                Console.WriteLine("media = " + media.ToString("F2", CultureInfo.InvariantCulture));

                Console.WriteLine("novo calculo (1-sim 2-nao)");
                novoCalc = int.Parse(Console.ReadLine());
                while (novoCalc != 1 && novoCalc != 2)
                {
                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    novoCalc = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}
