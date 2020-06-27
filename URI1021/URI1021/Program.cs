using System;
using System.Globalization;

namespace URI1021
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double N;
            int quociente, resto, notas, moedas;

            N = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            resto = (int)(N * 100.0 + 0.5); // assegurando que N seja inteiro e que seja devidamente arredondado

            Console.WriteLine("NOTAS:");

            // Anteriormene multiplicamos N por 100, portanto o valor de cada nota também deverá ser multiplicado por 100

            notas = 100;
            quociente = resto / (notas * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + notas + ".00");
            resto = resto % (notas * 100);

            notas = 50;
            quociente = resto / (notas * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + notas + ".00");
            resto = resto % (notas * 100);

            notas = 20;
            quociente = resto / (notas * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + notas + ".00");
            resto = resto % (notas * 100);

            notas = 10;
            quociente = resto / (notas * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + notas + ".00");
            resto = resto % (notas * 100);

            notas = 5;
            quociente = resto / (notas * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + notas + ".00");
            resto = resto % (notas * 100);

            notas = 2;
            quociente = resto / (notas * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + notas + ".00");
            resto = resto % (notas * 100);

            Console.WriteLine("MOEDAS:");
            // o valor de cada moeda deverá ser representado em centavos

            moedas = 100;
            quociente = resto / moedas;
            Console.WriteLine(quociente + " moeda(s) de R$ 1.00");
            resto = resto % moedas;

            moedas = 50;
            quociente = resto / moedas;
            Console.WriteLine(quociente + " moeda(s) de R$ 0.50");
            resto = resto % moedas;

            moedas = 25;
            quociente = resto / moedas;
            Console.WriteLine(quociente + " moeda(s) de R$ 0.25");
            resto = resto % moedas;

            moedas = 10;
            quociente = resto / moedas;
            Console.WriteLine(quociente + " moeda(s) de R$ 0.10");
            resto = resto % moedas;

            moedas = 5;
            quociente = resto / moedas;
            Console.WriteLine(quociente + " moeda(s) de R$ 0.05");
            resto = resto % moedas;

            Console.WriteLine(resto + " moeda(s) de R$ 0.01");
        }
    }
}