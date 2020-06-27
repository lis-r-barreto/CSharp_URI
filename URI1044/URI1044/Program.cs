using System;

namespace URI1044
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int A, B, restoAB, restoBA;

            String[] vet = Console.ReadLine().Split(' ');

            A = int.Parse(vet[0]);
            B = int.Parse(vet[1]);

            restoAB = A % B;
            restoBA = B % A;

            if (restoAB == 0 || restoBA == 0) {
                Console.WriteLine("Sao Multiplos");
            }
            else{
                Console.WriteLine("Nao sao Multiplos");
            }
        }
    }
}