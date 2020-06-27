using System;

namespace URI1035
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int A, B, C, D, somaAB, somaCD, restoA;

            String[] vet = Console.ReadLine().Split(' ');

            A = int.Parse(vet[0]);
            B = int.Parse(vet[1]);
            C = int.Parse(vet[2]);
            D = int.Parse(vet[3]);

            somaAB = A + B;
            somaCD = C + D;
            restoA = A % 2;

            if (B > C && D > A && somaCD > somaAB && C > 0 && D > 0 && restoA == 0) {
                Console.WriteLine("Valores aceitos");
            }
            else {
                Console.WriteLine("Valores nao aceitos");
            }
        }
    }
}
