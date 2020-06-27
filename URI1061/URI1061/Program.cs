using System;

namespace URI1061
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int X1, Y1, Z1, W1, X2, Y2, Z2, W2, W, X, Y, Z, inicio, fim, duracao, resto;

            string[] vet = Console.ReadLine().Split(' ');
            W1 = int.Parse(vet[1]);

            vet = Console.ReadLine().Split(' ');
            X1 = int.Parse(vet[0]);
            Y1 = int.Parse(vet[2]);
            Z1 = int.Parse(vet[4]);

            vet = Console.ReadLine().Split(' ');
            W2 = int.Parse(vet[1]);

            vet = Console.ReadLine().Split(' ');
            X2 = int.Parse(vet[0]);
            Y2 = int.Parse(vet[2]);
            Z2 = int.Parse(vet[4]);

            inicio = (W1 - 1) * 24 * 60 * 60 + X1 * 60 * 60 + Y1 * 60 + Z1;
            fim = (W2 - 1) * 24 * 60 * 60 + X2 * 60 * 60 + Y2 * 60 + Z2;
            duracao = fim - inicio;

            W = duracao / (24 * 60 * 60);
            resto = duracao % (24 * 60 * 60);
            X = resto / (60 * 60);
            resto = resto % (60 * 60);
            Y = resto / 60;
            Z = resto % 60;

            Console.WriteLine(W + " dia(s)");
            Console.WriteLine(X + " hora(s)");
            Console.WriteLine(Y + " minuto(s)");
            Console.WriteLine(Z + " segundo(s)");
        }
    }
}