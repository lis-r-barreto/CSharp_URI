using System;
using System.Globalization;

namespace URI1038
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int codigo, qtd;
            double cachorroQuente, xSalada, xBacon, torrada, refrigerante;

            String[] vet = Console.ReadLine().Split(' ');

            codigo = int.Parse(vet[0]);
            qtd = int.Parse(vet[1]);

            cachorroQuente = 4.00 * qtd;
            xSalada = 4.50 * qtd;
            xBacon = 5.00 * qtd;
            torrada = 2.00 *qtd;
            refrigerante = 1.50 * qtd;


            switch (codigo)
            {
                case 1:
                    Console.WriteLine("Total: R$ " + cachorroQuente.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 2:
                    Console.WriteLine("Total: R$ " + xSalada.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 3:
                    Console.WriteLine("Total: R$ " + xBacon.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 4:
                    Console.WriteLine("Total: R$ " + torrada.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 5:
                    Console.WriteLine("Total: R$ " + refrigerante.ToString("F2", CultureInfo.InvariantCulture));
                    break;
            }
        }
    }
}