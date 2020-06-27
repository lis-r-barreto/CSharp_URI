using System;

namespace URI1042
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, n1, n2, n3;

            string[] vet = Console.ReadLine().Split(' ');
            A = int.Parse(vet[0]);
            B = int.Parse(vet[1]);
            C = int.Parse(vet[2]);

            if (A < B && A < C)
            {
                 n1 = A;
                if (B < C)
                {
                    n2 = B;
                    n3 = C;
                }
                else
                {
                    n2 = C;
                    n3 = B;
                }
            }

            else if (B < C)
            {
                n1 = B;
                if (A < C)
                {
                    n2 = A;
                    n3 = C;
                }
                else
                {
                    n2 = C;
                    n3 = A;
                }
            }
            else
            {
                n1 = C;
                if (B < A)
                {
                    n2 = B;
                    n3 = A;
                }
                else
                {
                    n2 = A;
                    n3 = B;
                }
            }
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine();
            Console.WriteLine(A);
            Console.WriteLine(B);
            Console.WriteLine(C);
        }
    }
}
