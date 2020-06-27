using System;
using System.Globalization;

namespace URI1017
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int tempo, velocidadeMedia;
            double distanciaPercorrida, qtdCombustivel;

            tempo = int.Parse(Console.ReadLine());
            velocidadeMedia = int.Parse(Console.ReadLine());

            distanciaPercorrida = velocidadeMedia * tempo;
            qtdCombustivel = distanciaPercorrida / 12.0;

            Console.WriteLine(qtdCombustivel.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}