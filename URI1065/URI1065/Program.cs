using System;

namespace URI1065
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4, n5, qtdPares;

            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());
            n4 = int.Parse(Console.ReadLine());
            n5 = int.Parse(Console.ReadLine());

            qtdPares = 0;

            if (n1 % 2 == 0)
            {
                qtdPares += 1;
            }
            else
            {
                qtdPares += 0;
            }
            if (n2 % 2 == 0)
            {
                qtdPares += 1;
            }
            else
            {
                qtdPares += 0;
            }
            if (n3 % 2 == 0)
            {
                qtdPares += 1;
            }
            else
            {
                qtdPares += 0;
            }
            if (n4 % 2 == 0)
            {
                qtdPares += 1;
            }
            else
            {
                qtdPares += 0;
            }
            if (n5 % 2 == 0)
            {
                qtdPares += 1;
            }
            else
            {
                qtdPares += 0;
            }

            Console.WriteLine(qtdPares + " valores pares");
        }
    }
}
