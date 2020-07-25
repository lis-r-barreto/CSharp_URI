using System;
using System.Globalization;

namespace URI1094
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int N;
            N = int.Parse(Console.ReadLine());

            int[] quantias = new int[N];
            char[] tipos = new char[N];

            // Leitura dos dados
            for (int i=0; i<N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                quantias[i] = int.Parse(s[0]);
                tipos[i] = char.Parse(s[1]);
            }

            // Total de cobaias utilizadas
            int total = 0;
            for (int i=0; i<N; i++)
            {
                total += quantias[i];
            }

            // Total de cada tipo de cobaia utilizada
            int qtdCoelhos = 0;
            int qtdRatos = 0;
            int qtdSapos = 0;
            for (int i=0; i<N; i++)
            {
                if (tipos[i] == 'C')
                {
                    qtdCoelhos += quantias[i];
                }
                else if (tipos[i] == 'R')
                {
                    qtdRatos += quantias[i];
                }
                else
                {
                    qtdSapos += quantias[i];
                }

            }

            // Percentual de cada tipo de cobaia em relação ao total de cobaias utilizadas
            double percentCoelhos = (double)qtdCoelhos / (double)total * 100.0;
            double percentRatos = (double)qtdRatos / (double)total * 100.0;
            double percentSapos = (double)qtdSapos / (double)total * 100.0;

            Console.WriteLine("Total: " + total + " cobaias");
            Console.WriteLine("Total de coelhos: " + qtdCoelhos);
            Console.WriteLine("Total de ratos: " + qtdRatos);
            Console.WriteLine("Total de sapos: " + qtdSapos);
            Console.WriteLine("Percentual de coelhos: " + percentCoelhos.ToString("F2",
                CultureInfo.InvariantCulture) + " %");
            Console.WriteLine("Percentual de ratos: " + percentRatos.ToString("F2",
                CultureInfo.InvariantCulture) + " %");
            Console.WriteLine("Percentual de sapos: " + percentSapos.ToString("F2",
                CultureInfo.InvariantCulture) + " %");
        }
    }
}
