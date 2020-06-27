using System;
using System.Globalization;

namespace URI1010
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int codigo1, codigo2, qtdPecas1, qtdPecas2;
            double preco1, preco2, total;

            string[] valores = Console.ReadLine().Split(' ');
            codigo1 = int.Parse(valores[0]);
            qtdPecas1 = int.Parse(valores[1]);
            preco1 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            valores = Console.ReadLine().Split(' ');
            codigo2 = int.Parse(valores[0]);
            qtdPecas2 = int.Parse(valores[1]);
            preco2 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            total = preco1 * qtdPecas1 + preco2 * qtdPecas2;

            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}