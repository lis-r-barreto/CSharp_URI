using System;

namespace URI1018
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int N, notas100, resto100, notas50, resto50, notas20, resto20, 
            notas10, resto10, notas5, resto5, notas2, resto2, notas1;

            N = int.Parse(Console.ReadLine());
            Console.WriteLine(N);

            notas100 = N / 100;
            resto100 = N % 100;
            Console.WriteLine(notas100 + " nota(s) de R$ 100,00");

            notas50 = resto100 / 50;
            resto50 = resto100 % 50;
            Console.WriteLine(notas50 + " nota(s) de R$ 50,00");

            notas20 = resto50 / 20;
            resto20 = resto50 % 20;
            Console.WriteLine(notas20 + " nota(s) de R$ 20,00");

            notas10 = resto20 / 10;
            resto10 = resto20 % 10;
            Console.WriteLine(notas10 + " nota(s) de R$ 10,00");

            notas5 = resto10 / 5;
            resto5 = resto10 % 5;
            Console.WriteLine(notas5 + " nota(s) de R$ 5,00");

            notas2 = resto5 / 2;
            resto2 = resto5 % 2;
            Console.WriteLine(notas2 + " nota(s) de R$ 2,00");

            notas1 = resto2;
            Console.WriteLine(notas1 + " nota(s) de R$ 1,00");

        }
    }
}
